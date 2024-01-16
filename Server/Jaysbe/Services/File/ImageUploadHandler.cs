using System.Net;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Jaysbe.Services.File;

public class ImageUploadHandler : IImageUploadHandler
{
    private readonly ILogger<ImageUploadHandler> _logger;
    private readonly IConfiguration _configuration;

    public ImageUploadHandler(ILogger<ImageUploadHandler> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    private static readonly Dictionary<string, List<byte[]>> FileSignature = new Dictionary<string, List<byte[]>>
    {
        {
            ".png", new List<byte[]>
            {
                new byte[] { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A }
            }
        },
        {
            ".jpeg", new List<byte[]>
            {
                new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 },
                new byte[] { 0xFF, 0xD8, 0xFF, 0xE2 },
                new byte[] { 0xFF, 0xD8, 0xFF, 0xE3 },
                new byte[] { 0xFF, 0xD8, 0xFF, 0xEE },
            }
        },
        {
            ".jpg", new List<byte[]>
            {
                new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 },
                new byte[] { 0xFF, 0xD8, 0xFF, 0xE1 },
                new byte[] { 0xFF, 0xD8, 0xFF, 0xE8 },
                new byte[] { 0xFF, 0xD8, 0xFF, 0xEE },
                new byte[] { 0xFF, 0xD8, 0xFF, 0xE0, 0x00, 0x10, 0x4A, 0x46, 0x49, 0x46, 0x00, 0x01 },
            }
        }
    };

    public async Task<(string path, bool isSuccessful, string[]? errorMessages)> AddImageAsync(IFormFile formFile,
        ModelStateDictionary modelState)
    {
        var trustedFileNameForDisplay = WebUtility.HtmlEncode(formFile.FileName);
        _logger.LogInformation($"{nameof(AddImageAsync)} processing file [{trustedFileNameForDisplay}].");
        // Get config
        var allowedImageExtensions = _configuration["AllowedImageExtensions"]?.Split(" ") ??
                                     throw new NullReferenceException(
                                         "AllowedImageExtensions not found in configuration");

        var maxFileSize = Int32.Parse(_configuration["MaxImageSizeBytes"] ??
                                      throw new NullReferenceException("MaxImageSizeBytes not found in configuration"));
        var path = _configuration["ProductImageUploadPath"] ??
                   throw new NullReferenceException("ProductImageUploadPath not found in configuration");

        var processedFormFile =
            await ProcessFormFile<FormFile>(formFile, modelState, allowedImageExtensions, maxFileSize);

        if (processedFormFile.Length == 0)
        {
            return ("", false, modelState.Select(x => x.Value?.ToString()).ToArray());
        }

        // Checks
        if (formFile.Length <= 0)
            return ("", false, new[] { "File is empty" });

        var ext = Path.GetExtension(formFile.FileName);
        var extension = ext.ToLowerInvariant();

        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);

        var filePath = Path.Combine(path, Guid.NewGuid() + extension);

        await using (var stream = System.IO.File.Create(filePath))
        {
            await stream.WriteAsync(processedFormFile, 0, processedFormFile.Length);
            _logger.LogInformation(
                $"{nameof(AddImageAsync)} uploaded file [{trustedFileNameForDisplay}] as ({Path.GetFileName(filePath)}).");
        }

        return (filePath, true, null);
    }

    public async Task<(IEnumerable<string> paths, bool isSuccessful, string[]? errorMessages)> AddImagesAsync(
        IEnumerable<IFormFile> images, ModelStateDictionary modelState)
    {
        var formFiles = images as IFormFile[] ?? images.ToArray();
        _logger.LogInformation($"{nameof(AddImagesAsync)} called with [{formFiles.Length}] file to process");

        if (formFiles.Length == 0)
            throw new ArgumentNullException(nameof(images));

        List<string> pathList = new();
        List<string> errors = new();

        foreach (var formFile in formFiles)
        {
            var temp = await AddImageAsync(formFile, modelState);
            pathList.Add(temp.path);

            if (temp.errorMessages?.Length > 0)
            {
                errors = errors.Concat(temp.errorMessages).ToList();
            }
        }

        return new ValueTuple<IEnumerable<string>, bool, string[]?>(pathList, errors.Count == 0,
            errors.Count > 0 ? errors.ToArray() : null);
    }

    private static async Task<byte[]> ProcessFormFile<T>(IFormFile formFile,
        ModelStateDictionary modelState, string[] permittedExtensions,
        long sizeLimit)
    {
        var fieldDisplayName = string.Empty;
        var trustedFileNameForDisplay = WebUtility.HtmlEncode(formFile.FileName);

        // Check the file length. This check doesn't catch files that only have 
        // a BOM as their content.
        if (formFile.Length == 0)
        {
            modelState.AddModelError(formFile.Name,
                $"{fieldDisplayName}({trustedFileNameForDisplay}) is empty.");

            return Array.Empty<byte>();
        }

        if (formFile.Length > sizeLimit)
        {
            var megabyteSizeLimit = sizeLimit / 1048576;
            modelState.AddModelError(formFile.Name,
                $"{fieldDisplayName}({trustedFileNameForDisplay}) exceeds " +
                $"{megabyteSizeLimit:N1} MB.");

            return Array.Empty<byte>();
        }

        try
        {
            using (var memoryStream = new MemoryStream())
            {
                await formFile.CopyToAsync(memoryStream);

                // Check the content length in case the file's only
                // content was a BOM and the content is actually
                // empty after removing the BOM.
                if (memoryStream.Length == 0)
                {
                    modelState.AddModelError(formFile.Name,
                        $"{fieldDisplayName}({trustedFileNameForDisplay}) is empty.");
                }

                if (!IsValidFileExtensionAndSignature(
                        formFile.FileName, memoryStream, permittedExtensions))
                {
                    modelState.AddModelError(formFile.Name,
                        $"{fieldDisplayName}({trustedFileNameForDisplay}) file " +
                        "type isn't permitted or the file's signature " +
                        "doesn't match the file's extension.");
                }
                else
                {
                    return memoryStream.ToArray();
                }
            }
        }
        catch (Exception ex)
        {
            modelState.AddModelError(formFile.Name,
                $"{fieldDisplayName}({trustedFileNameForDisplay}) upload failed. " +
                $"Error: {ex.HResult}");
        }

        return Array.Empty<byte>();
    }

    private static bool IsValidFileExtensionAndSignature(string fileName, Stream data, string[] permittedExtensions)
    {
        if (string.IsNullOrEmpty(fileName) || data.Length == 0)
        {
            return false;
        }

        var ext = Path.GetExtension(fileName).ToLowerInvariant();

        if (string.IsNullOrEmpty(ext) || !permittedExtensions.Contains(ext))
        {
            return false;
        }

        data.Position = 0;

        using (var reader = new BinaryReader(data))
        {
            var signatures = FileSignature[ext];
            var headerBytes = reader.ReadBytes(signatures.Max(m => m.Length));

            return signatures.Any(signature => headerBytes.Take(signature.Length).SequenceEqual(signature));
        }
    }
}