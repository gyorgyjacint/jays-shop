﻿namespace Jaysbe.Services.File;

public interface IImageUploadHandler
{
    public Task<(string path, bool isSuccessful, string[]? errorMessages)> AddImageAsync(IFormFile image);
    public Task<(IEnumerable<string> paths, bool isSuccessful, string[]? errorMessages)> AddImagesAsync(IEnumerable<IFormFile> images);
}