using System.ComponentModel;
using System.Net;
using System.Text.Json;
using Jaysbe.IntegrationTests.Bases;
using Microsoft.AspNetCore.Http;

namespace Jaysbe.IntegrationTests.Controllers;

[Collection("tests")]
public class ProductControllerTests : AuthBase, IClassFixture<CustomWebApplicationFactory<Program>>
{
    public ProductControllerTests(CustomWebApplicationFactory<Program> applicationFactory)
        : base(applicationFactory, "admin@admin.com", "admin123")
    {
    }

    [Theory]
    [InlineData("/api/product/post")]
    public async Task Post_Returns_Success_OnValid(string url)
    {
        // Arrange
        var validFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestSources/valid-1.png");
        var fileContent = GetFileContent(validFilePath);
        
        var multiPartFormDataContent = new MultipartFormDataContent();
        multiPartFormDataContent.Add(new StringContent("test1"), "Name");
        multiPartFormDataContent.Add(new StringContent("asd1"), "Description");
        multiPartFormDataContent.Add(fileContent, "Thumbnail", Path.GetFileName(validFilePath));

        // Act
        var response = await AuthorizedClient.PostAsync(url, multiPartFormDataContent);
        var json = await response.Content.ReadAsStringAsync();
        var resContent = JsonSerializer.Deserialize<string>(json);
        
        // Assert
        Assert.True(response.IsSuccessStatusCode, "Invalid request");
        Assert.Equivalent(HttpStatusCode.Created, response.StatusCode);
        Assert.True(Guid.TryParse(resContent, out _), "Response content is not Guid");
        
        // Cleanup
        var cleanupResponse = await AuthorizedClient.DeleteAsync($"api/Product/Delete/{resContent}");
        if (!cleanupResponse.IsSuccessStatusCode)
            throw new WarningException($"{nameof(Post_Returns_Success_OnValid)}: Cleanup unsuccessful");
    }
    


    private IFormFile GetIFormFile(string path)
    {
        if (!File.Exists(path))
            Assert.Fail(nameof(path) + " is missing");

        var stream = new MemoryStream(File.ReadAllBytes(path).ToArray());
        var formFile = new FormFile(stream, 0, stream.Length, "formFile", Path.GetFileName(path));

        return formFile;
    }
    
    private ByteArrayContent GetFileContent(string path)
    {
        if (!File.Exists(path))
            Assert.Fail(nameof(path) + " is missing");

        var stream = new MemoryStream(File.ReadAllBytes(path).ToArray());

        return new ByteArrayContent(stream.ToArray());
    }
    
    private Stream GetFileStream(string path)
    {
        if (!File.Exists(path))
            Assert.Fail(nameof(path) + " is missing");

        var stream = new MemoryStream(File.ReadAllBytes(path).ToArray());

        return stream;
    }
}