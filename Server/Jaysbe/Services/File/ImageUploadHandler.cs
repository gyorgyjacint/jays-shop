namespace Jaysbe.Services.File;

public class ImageUploadHandler : IImageUploadHandler
{
    private ILogger<ImageUploadHandler> _logger;
    private IConfiguration _configuration;

    public ImageUploadHandler(ILogger<ImageUploadHandler> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public async Task<(string path, bool isSuccessful, string[]? errorMessages)> AddImageAsync(IFormFile image)
    {
        _logger.LogInformation(nameof(AddImageAsync) + " called with [1] file to process.");
        var allowedImageExtensions = _configuration["AllowedImageExtensions"]?.Split(" ") ??
                                     throw new NullReferenceException(
                                         "AllowedImageExtensions not found in configuration");

        var maxFileSize = Int32.Parse(_configuration["MaxImageSizeBytes"] ??
                                      throw new NullReferenceException("MaxImageSizeBytes not found in configuration"));

        var errorMessages = new List<string>();

        if (image.Length <= 0)
            return ("", false, new[] { "File is empty" });

        var ext = Path.GetExtension(image.FileName);
        var extension = ext.ToLower();

        if (!allowedImageExtensions.Contains(extension))
            errorMessages.Add("Invalid file extension.");
        if (image.Length > maxFileSize)
            errorMessages.Add("File too large");
        if (errorMessages.Count > 0)
            return ("", false, errorMessages.ToArray());

        var path = _configuration["ProductImageUploadPath"] ??
                   throw new NullReferenceException("ProductImageUploadPath not found in configuration");

        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);

        var filePath = Path.Combine(path, Guid.NewGuid() + extension);

        await using var stream = System.IO.File.Create(filePath);
        await image.CopyToAsync(stream);

        return (filePath, true, null);
    }

    public async Task<(IEnumerable<string> paths, bool isSuccessful, string[]? errorMessages)> AddImagesAsync(
        IEnumerable<IFormFile> images)
    {
        var formFiles = images as IFormFile[] ?? images.ToArray();
        _logger.LogInformation($"{nameof(AddImagesAsync)} called with [{formFiles.Length}] file to process");

        if (formFiles.Length == 0)
            throw new ArgumentNullException(nameof(images));

        List<string> pathList = new();
        List<string> errors = new();

        foreach (var formFile in formFiles)
        {
            var temp = await AddImageAsync(formFile);
            pathList.Add(temp.path);

            if (temp.errorMessages?.Length > 0)
            {
                errors = errors.Concat(temp.errorMessages).ToList();
            }
        }

        return new ValueTuple<IEnumerable<string>, bool, string[]?>(pathList, errors.Count == 0,
            errors.Count > 0 ? errors.ToArray() : null);
    }
}