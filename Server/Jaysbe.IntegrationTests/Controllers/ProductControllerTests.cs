using System.ComponentModel;
using System.Net;
using System.Text.Json;
using Jaysbe.IntegrationTests.Bases;
using Microsoft.AspNetCore.Http;

namespace Jaysbe.IntegrationTests.Controllers;

[Collection("tests")]
public class ProductControllerTests : AuthBase, IClassFixture<CustomWebApplicationFactory<Program>>
{
    private MultipartFormDataContent _multipartContentBase;
    
    public ProductControllerTests(CustomWebApplicationFactory<Program> applicationFactory)
        : base(applicationFactory, "admin@admin.com", "admin123")
    {
        _multipartContentBase = GetMultipartFormDataContent("TestSources/valid-1.png");
    }

    [Theory]
    [InlineData("/api/product/post")]
    public async Task Post_Returns_Success_OnValid(string url)
    {
        // Act
        var response = await AuthorizedClient.PostAsync(url, _multipartContentBase);
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
    
    [Theory]
    [InlineData("/api/product/post")]
    public async Task Post_Returns_BadRequest_OnInvalid(string url)
    {
        // Act
        var response = await AuthorizedClient.PostAsync(url, new MultipartFormDataContent());
        
        // Assert
        Assert.False(response.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.BadRequest, response.StatusCode);
    }
    
    [Theory]
    [InlineData("/api/product/post")]
    public async Task Post_Returns_Unauthorized(string url)
    {
        // Act
        var response = await UnauthorizedClient.PostAsync(url, _multipartContentBase);
        
        // Assert
        Assert.False(response.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.Unauthorized, response.StatusCode);
    }
    
    [Theory]
    [InlineData("/api/product/delete")]
    public async Task Delete_Returns_Success(string url)
    {
        // Arrange
        var data = _multipartContentBase;
        data.Add(new StringContent("test2"), "Name");
        var postResult = await AuthorizedClient.PostAsync("/api/product/post", data);
        var json = await postResult.Content.ReadAsStringAsync();
        var id = JsonSerializer.Deserialize<string>(json);
        
        // Act
        var response = await AuthorizedClient.DeleteAsync(url + "/" + id);
        
        // Assert
        Assert.True(response.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.OK, response.StatusCode);
    }
    
    [Theory]
    [InlineData("/api/product/delete")]
    public async Task Delete_Returns_NotFound(string url)
    {
        // Arrange
        var randomGuid = Guid.NewGuid();
        
        // Act
        var response = await AuthorizedClient.DeleteAsync(url + "/" + randomGuid);
        
        // Assert
        Assert.False(response.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.NotFound, response.StatusCode);
    }
    
    [Theory]
    [InlineData("/api/product/delete")]
    public async Task Delete_Returns_Unauthorized(string url)
    {
        // Arrange
        var randomGuid = Guid.NewGuid();
        
        // Act
        var response = await UnauthorizedClient.DeleteAsync(url + "/" + randomGuid);
        
        // Assert
        Assert.False(response.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.Unauthorized, response.StatusCode);
    }
    
    [Theory]
    [InlineData("/api/product/update")]
    public async Task Update_Returns_Success_OnValid(string url)
    {
        // Arrange
        var postResult = await AuthorizedClient.PostAsync("/api/product/post", _multipartContentBase);
        var postJson = await postResult.Content.ReadAsStringAsync();
        var id = JsonSerializer.Deserialize<string>(postJson);
        var copy = GetMultipartCopy(_multipartContentBase);
        copy.Add(new StringContent(id), "ProductId");
        copy.Add(new StringContent("brand"), "Brand");
        
        // Act
        var response = await AuthorizedClient.PatchAsync(url, copy);
        
        // Assert
        Assert.True(response.IsSuccessStatusCode, "Invalid request");
        Assert.Equivalent(HttpStatusCode.OK, response.StatusCode);
    }
    
    [Theory]
    [InlineData("/api/product/update")]
    public async Task Update_Returns_NotFound(string url)
    {
        // Arrange
        var id = Guid.NewGuid().ToString();
        var copy = GetMultipartCopy(_multipartContentBase);
        copy.Add(new StringContent(id), "ProductId");
        copy.Add(new StringContent("brand"), "Brand");
        
        // Act
        var response = await AuthorizedClient.PatchAsync(url, copy);
        
        // Assert
        Assert.True(!response.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.NotFound, response.StatusCode);
    }
    
    [Theory]
    [InlineData("/api/product/update")]
    public async Task Update_Returns_Unauthorized(string url)
    {
        // Act
        var response = await UnauthorizedClient.PatchAsync(url, _multipartContentBase);
        
        // Assert
        Assert.False(response.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.Unauthorized, response.StatusCode);
    }
    
    private ByteArrayContent GetFileContent(string path)
    {
        if (!File.Exists(path))
            Assert.Fail(nameof(path) + " is missing");

        var stream = new MemoryStream(File.ReadAllBytes(path).ToArray());

        return new ByteArrayContent(stream.ToArray());
    }

    private MultipartFormDataContent GetMultipartFormDataContent(string route)
    {
        var validFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, route);
        var fileContent = GetFileContent(validFilePath);
        var multiPartFormDataContent = new MultipartFormDataContent();
        
        multiPartFormDataContent.Add(new StringContent("test1"), "Name");
        multiPartFormDataContent.Add(new StringContent("asd1"), "Description");
        multiPartFormDataContent.Add(fileContent, "Thumbnail", Path.GetFileName(validFilePath));

        return multiPartFormDataContent;
    }

    private MultipartFormDataContent GetMultipartCopy(MultipartFormDataContent multipartFormDataContent)
    {
        var copy = new MultipartFormDataContent();
        foreach (var content in multipartFormDataContent)
        {
            copy.Add(content);
        }

        return copy;
    }
}