using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Jaysbe.Services.File;

public interface IProductImageService
{
    public Task<(string path, bool isSuccessful, string[]? errorMessages)> AddImageAsync(IFormFile image,
        ModelStateDictionary modelState);
    public Task<(IEnumerable<string> paths, bool isSuccessful, string[]? errorMessages)> AddImagesAsync(IEnumerable<IFormFile> images, ModelStateDictionary modelState);
    public bool RemoveFile(string accessRoute);
}