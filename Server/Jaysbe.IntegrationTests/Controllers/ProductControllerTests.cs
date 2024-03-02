using System.ComponentModel;
using System.Net;
using System.Text.Json;
using Jaysbe.IntegrationTests.Bases;
using Jaysbe.Models;

namespace Jaysbe.IntegrationTests.Controllers;

[Collection("tests")]
public class ProductControllerTests : AuthBase, IClassFixture<CustomWebApplicationFactory<Program>>
{
    private readonly MultipartFormDataContent _multipartContentBase;
    private const string ValidFileRoute = "TestSources/valid-1.png";

    public ProductControllerTests(CustomWebApplicationFactory<Program> applicationFactory)
        : base(applicationFactory, "admin@admin.com", "admin123")
    {
        _multipartContentBase = GetMultipartFormDataContent(ValidFileRoute);
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
    [InlineData("/api/product/getbyid")]
    public async Task GetById_Returns_Correct_Values(string url)
    {
        // Arrange
        var content = new MultipartFormDataContent();
        var subCatJson = JsonSerializer.Serialize(
            new[]
            {
                new SubCategory { Name = "PostCorrectSubCat-1" },
                new SubCategory { Name = "PostCorrectSubCat-2" }
            });
        var prodDescJson = JsonSerializer.Serialize(
            new[]
            {
                new ProductDescOption { Name = "Screen size", Option = "3000 px", DescType = "Technical" },
                new ProductDescOption { Name = "Weight", Option = "300 g", DescType = "Technical" }
            });
        var multipartContent = new Dictionary<string, HttpContent>
        {
            { "ProductId", new StringContent(Guid.NewGuid().ToString()) },
            { "Name", new StringContent("PostCorrectValues-1") },
            { "Brand", new StringContent("PostCorrectBrand-1") },
            { "Price", new StringContent("125") },
            { "DiscountPrice", new StringContent("100") },
            { "Quantity", new StringContent("30") },
            { "Description", new StringContent("desc") },
            { "Color", new StringContent("color") },
            { "Category.Name", new StringContent("PostCorrectCat-1") },
            { "Category.SubCategories", new StringContent(subCatJson) },
            { "ProductDescriptions", new StringContent(prodDescJson) }
        };

        foreach (var (name, httpContent) in multipartContent)
            content.Add(httpContent, name);
        content.Add(GetFileContent(ValidFileRoute), "Thumbnail", Path.GetFileName(ValidFileRoute));

        // Act
        var postResponse = await AuthorizedClient.PostAsync("api/Product/Post", content);
        var postContentJson = await postResponse.Content.ReadAsStringAsync();
        var id = JsonSerializer.Deserialize<string>(postContentJson);

        var getResponse = await AuthorizedClient.GetAsync($"{url}/{id}");
        var productJson = await getResponse.Content.ReadAsStringAsync();
        var product = JsonSerializer.Deserialize<Product>(productJson,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        // Assert
        if (product?.ProductId == null)
            Assert.Fail("Could not get created product");

        Assert.True(postResponse.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.Created, postResponse.StatusCode);

        Assert.True(getResponse.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.OK, getResponse.StatusCode);
        Assert.Multiple(() =>
        {
            Assert.Equivalent("PostCorrectValues-1", product.Name);
            Assert.Equivalent("PostCorrectBrand-1", product.Brand);
            Assert.Equivalent(125m, product.Price);
            Assert.Equivalent(100m, product.DiscountPrice);
            Assert.Equivalent(30, product.Quantity);
            Assert.Equivalent("desc", product.Description);
            Assert.Equivalent("color", product.Color);
            
            // TODO check: created, tied with FK in DB, but doesnt get returned
            //Assert.Equivalent("PostCorrectCat-1", product.Category?.Name);
            //Assert.True(product.Category?.SubCategories?.Any(s => s.Name == "PostCorrectSubCat-1"));
            //Assert.True(product.Category?.SubCategories?.Any(s => s.Name == "PostCorrectSubCat-2"));
            //Assert.Equivalent(2, product.Category?.SubCategories?.Count());
        });
    }
    
    [Theory]
    [InlineData("/api/product/getbyid")]
    public async Task GetById_Returns_NotFound_No_Regard_To_Auth(string url)
    {
        // Arrange
        var id = Guid.NewGuid();
        
        // Act
        var authorizedResponse = await AuthorizedClient.GetAsync($"{url}/{id}");
        var unauthorizedResponse = await UnauthorizedClient.GetAsync($"{url}/{id}");
        
        // Assert
        Assert.False(authorizedResponse.IsSuccessStatusCode || unauthorizedResponse.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.NotFound, authorizedResponse.StatusCode);
        Assert.Equivalent(HttpStatusCode.NotFound, unauthorizedResponse.StatusCode);
    }
    
    [Theory]
    [InlineData("/api/product/getbyid")]
    public async Task GetById_Returns_Product_No_Regard_To_Auth(string url)
    {
        // Arrange
        var content = GetMultipartCopy(_multipartContentBase);
        content.Add(new StringContent("GetById_Returns_Product_No_Regard_To_Auth"), "Name");
        var postResponse = await AuthorizedClient.PostAsync("/api/product/post", content);
        var idJson = await postResponse.Content.ReadAsStringAsync();
        var id = JsonSerializer.Deserialize<string>(idJson);
        
        if (!postResponse.IsSuccessStatusCode)
            Assert.Fail($"{nameof(GetById_Returns_Product_No_Regard_To_Auth)}: Posting product failed");
        
        // Act
        var authorizedResponse = await AuthorizedClient.GetAsync($"{url}/{id}");
        var unauthorizedResponse = await UnauthorizedClient.GetAsync($"{url}/{id}");

        var authJson = await authorizedResponse.Content.ReadAsStringAsync();
        var unauthJson = await unauthorizedResponse.Content.ReadAsStringAsync();
        var option = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        var authProduct = JsonSerializer.Deserialize<Product>(authJson, option);
        var unauthProduct = JsonSerializer.Deserialize<Product>(unauthJson, option);
        
        // Assert
        Assert.True(authorizedResponse.IsSuccessStatusCode && unauthorizedResponse.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.OK, authorizedResponse.StatusCode);
        Assert.Equivalent(HttpStatusCode.OK, unauthorizedResponse.StatusCode);
        Assert.True(authProduct?.ProductId != null);
        Assert.True(unauthProduct?.ProductId != null);
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

        if (id == null)
            Assert.Fail($"{nameof(Update_Returns_Success_OnValid)}: Unable to create/post product (Arrange)");

        var content = GetMultipartCopy(_multipartContentBase);
        content.Add(new StringContent(id), "ProductId");
        content.Add(new StringContent("brand"), "Brand");

        // Act
        var response = await AuthorizedClient.PatchAsync(url, content);

        // Assert
        Assert.True(response.IsSuccessStatusCode, "Invalid request");
        Assert.Equivalent(HttpStatusCode.OK, response.StatusCode);
    }

    [Theory]
    [InlineData("/api/product/update")]
    public async Task Update_Returns_NotFound_OnInvalid(string url)
    {
        // Arrange
        var content = GetMultipartCopy(_multipartContentBase);

        // Act
        var response = await AuthorizedClient.PatchAsync(url, content);

        // Assert
        Assert.False(response.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.NotFound, response.StatusCode);
    }

    [Theory]
    [InlineData("/api/product/update")]
    public async Task Update_Returns_NotFound(string url)
    {
        // Arrange
        var id = Guid.NewGuid().ToString();
        var content = GetMultipartCopy(_multipartContentBase);
        content.Add(new StringContent(id), "ProductId");
        content.Add(new StringContent("brand"), "Brand");

        // Act
        var response = await AuthorizedClient.PatchAsync(url, content);

        // Assert
        Assert.False(response.IsSuccessStatusCode);
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

    [Theory]
    [InlineData("/api/product/getall")]
    public async Task GetAll_Returns_Correct_Count(string url)
    {
        // Arrange
        var baseContent = GetMultipartFormDataContent(ValidFileRoute);
        var multipartForms = new[]
        {
            GetMultipartCopy(baseContent),
            GetMultipartCopy(baseContent),
            GetMultipartCopy(baseContent),
            GetMultipartCopy(baseContent),
            GetMultipartCopy(baseContent),
        };

        foreach (var part in multipartForms)
        {
            var postResult = await AuthorizedClient.PostAsync("/api/product/post", part);
            Assert.True(postResult.IsSuccessStatusCode);
        }
        
        // Act
        var response = await UnauthorizedClient.GetAsync(url);
        var jsonContent = await response.Content.ReadAsStringAsync();
        var content = JsonSerializer.Deserialize<Product[]>(jsonContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        
        // Assert
        Assert.True(response.IsSuccessStatusCode);
        Assert.True(content?.Length >= 5);
        Assert.True(content.All(c => c.ProductId != null));
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
            copy.Add(content);

        return copy;
    }
}