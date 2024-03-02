using System.Net;
using System.Net.Http.Json;
using Jaysbe.IntegrationTests.Bases;
using Jaysbe.Models;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Jaysbe.IntegrationTests.Controllers;

[Collection("tests")]
public class CategoryControllerTests : AuthBase, IClassFixture<CustomWebApplicationFactory<Program>>
{
    public CategoryControllerTests(CustomWebApplicationFactory<Program> applicationFactory)
        : base(applicationFactory, "admin@admin.com", "admin123")
    {
    }

    [Theory]
    [InlineData("/api/category/post")]
    public async Task Post_Returns_Unauthorized(string url)
    {
        // Arrange
        var client = ApplicationFactory.CreateClient();
        var data = new Category
        {
            Name = "err"
        };
        var content = JsonContent.Create(data);

        // Act
        var response = await client.PostAsync(url, content);

        // Assert
        Assert.True(response.StatusCode == HttpStatusCode.Unauthorized);
    }

    [Theory]
    [InlineData("/api/category/post")]
    public async Task Post_Returns_Success(string url)
    {
        // Arrange
        var data = new Category
        {
            Name = "test1"
        };
        var content = JsonContent.Create(data);

        // Act
        var response = await AuthorizedClient.PostAsync(url, content);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.True(response.IsSuccessStatusCode);
            Assert.True(response.StatusCode == HttpStatusCode.Created);
        });
    }

    [Theory]
    [InlineData("/api/category/post")]
    public async Task Post_Returns_BadResult_On_Duplicate_Name(string url)
    {
        // Arrange
        var data = new Category
        {
            CategoryId = Guid.NewGuid(),
            Name = "test1"
        };
        var content = JsonContent.Create(data);

        // Act
        var firstResponse = await AuthorizedClient.PostAsync(url, content);
        var response = await AuthorizedClient.PostAsync(url, content);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.True(firstResponse.IsSuccessStatusCode);
            Assert.False(response.IsSuccessStatusCode);
            Assert.True(response.StatusCode == HttpStatusCode.BadRequest);
        });
    }

    [Theory]
    [InlineData("/api/category/getall")]
    public async Task GetAll_Returns_Categories(string url)
    {
        // Act
        var response = await AuthorizedClient.GetAsync(url);
        var json = await response.Content.ReadAsStringAsync();
        var responseData = JsonConvert.DeserializeObject<Category[]>(json);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.True(response.IsSuccessStatusCode);
            Assert.True(responseData?.Length > 0);
        });
    }

    [Theory]
    [InlineData("/api/category/getall")]
    public async Task GetAll_Returns_Empty_Collection(string url)
    {
        // Act
        var response = await AuthorizedClient.GetAsync(url);
        var json = await response.Content.ReadAsStringAsync();
        var responseData = JsonConvert.DeserializeObject<Category[]>(json);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.True(response.IsSuccessStatusCode);
            Assert.False(responseData?.Any());
        });
    }

    [Theory]
    [InlineData("/api/category/delete")]
    public async Task Delete_Returns_Success(string url)
    {
        // Arrange
        var data = new Category
        {
            Name = "toDelete"
        };
        var postContent = JsonContent.Create(data);
        var postResponse = await AuthorizedClient.PostAsync("/api/category/post", postContent);
        var id = await postResponse.Content.ReadAsStringAsync();
        Assert.True(postResponse.IsSuccessStatusCode);

        // Act
        var response = await AuthorizedClient.DeleteAsync(url + "/" + id);

        // Assert
        Assert.True(response.IsSuccessStatusCode);
    }
}