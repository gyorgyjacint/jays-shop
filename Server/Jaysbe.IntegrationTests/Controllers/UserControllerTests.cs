using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Jaysbe.Contracts;
using Jaysbe.Dtos;
using Jaysbe.IntegrationTests.Bases;
using Microsoft.AspNetCore.Identity;

namespace Jaysbe.IntegrationTests.Controllers;

[Collection("tests")]
public class UserControllerTests : AuthBase, IClassFixture<CustomWebApplicationFactory<Program>>
{
    public UserControllerTests(CustomWebApplicationFactory<Program> applicationFactory)
        : base(applicationFactory, "admin@admin.com", "admin123")
    { }

    [Theory]
    [InlineData("/api/user/getall")]
    public async Task GetAll_Needs_Admin_Role(string url)
    {
        // Act
        var response = await UnauthorizedClient.GetAsync(url);
        
        // Assert
        Assert.False(response.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.Unauthorized, response.StatusCode);
    }
    
    [Theory]
    [InlineData("/api/user/getall")]
    public async Task GetAll_Returns_Users(string url)
    {
        // Arrange
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        
        // Act
        var response = await AuthorizedClient.GetAsync(url);
        var json = await response.Content.ReadAsStringAsync();
        var content = JsonSerializer.Deserialize<IdentityUser[]>(json, options);
        
        // Assert
        Assert.True(response.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.OK, response.StatusCode);
        Assert.NotNull(content);
        Assert.True(content.Length > 0);
    }
    
    [Theory]
    [InlineData("/api/user/update")]
    public async Task Update_Needs_Admin_Role(string url)
    {
        // Act
        var response = await UnauthorizedClient.PatchAsync(url, new StringContent(""));
        
        // Assert
        Assert.False(response.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.Unauthorized, response.StatusCode);
    }
    
    [Theory]
    [InlineData("/api/user/update")]
    public async Task Update_Returns_BadRequest_OnInvalid(string url)
    {
        // Arrange
        var nRandom = new Random().Next();
        var data = new RegistrationRequest($"test-{nRandom}", $"user-{nRandom}", $"password{nRandom}");
        var content = JsonContent.Create(data);
        
        // Act
        var response = await AuthorizedClient.PatchAsync(url, content);
        
        // Assert
        Assert.False(response.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.BadRequest, response.StatusCode);
    }
    
    [Theory]
    [InlineData("/api/user/update")]
    public async Task Update_IsCorrect(string url)
    {
        // Arrange
        var nRandom = new Random().Next();
        var postData = new RegistrationRequest($"test-{nRandom}@user.com", $"user-{nRandom}", $"password{nRandom}");
        var postContent = JsonContent.Create(postData);
        var postResponse = await AuthorizedClient.PostAsync("/api/auth/register", postContent);
        if (!postResponse.IsSuccessStatusCode)
            Assert.Fail("Registering new user to update failed");
        
        var usersResponse = await AuthorizedClient.GetAsync("api/User/GetAll");
        var usersJson = await usersResponse.Content.ReadAsStringAsync();
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var users = JsonSerializer.Deserialize<UserDto<string>[]>(usersJson, options);
        var user = users?.FirstOrDefault(dto => dto.UserName != null && !dto.UserName.Contains("admin", StringComparison.CurrentCultureIgnoreCase));
        Assert.NotNull(user);
        var contentData = new UserDto<string>
        {
            Id = user.Id,
            Email = "test--1@user.com",
            UserName = $"user-{nRandom}"
        };
        var content = JsonContent.Create(contentData);
        
        // Act
        var response = await AuthorizedClient.PatchAsync(url, content);
        var id = await response.Content.ReadAsStringAsync();
        var checkResponse = await AuthorizedClient.GetAsync($"api/User/GetById/{id}");
        var checkJson = await checkResponse.Content.ReadAsStringAsync();
        var userDto = JsonSerializer.Deserialize<UserDto<string>>(checkJson, options);
        
        // Assert
        Assert.True(response.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.OK, response.StatusCode);
        Assert.NotNull(userDto);
        Assert.Equivalent(contentData.Email, userDto.Email);
    }
    
    [Theory]
    [InlineData("/api/user/delete/")]
    public async Task Delete_Is_Successful(string url)
    {
        // Arrange
        var nRandom = new Random().Next();
        var postData = new RegistrationRequest($"test-{nRandom}@user.com", $"user-{nRandom}", $"password{nRandom}");
        var postContent = JsonContent.Create(postData);
        var postResponse = await AuthorizedClient.PostAsync("/api/auth/register", postContent);
        if (!postResponse.IsSuccessStatusCode)
            Assert.Fail("Registering new user to update failed");
        
        var usersResponse = await AuthorizedClient.GetAsync("api/User/GetAll");
        var usersJson = await usersResponse.Content.ReadAsStringAsync();
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var users = JsonSerializer.Deserialize<UserDto<string>[]>(usersJson, options);
        var user = users?.FirstOrDefault(dto => dto.UserName != null && !dto.UserName.Contains("admin", StringComparison.CurrentCultureIgnoreCase));
        Assert.NotNull(user);
        
        // Act
        var response = await AuthorizedClient.DeleteAsync(url + user.Id);
        var checkResponse = await AuthorizedClient.GetAsync("api/User/GetAll");
        var contentJson = await checkResponse.Content.ReadAsStringAsync();
        var content = JsonSerializer.Deserialize<UserDto<string>[]>(contentJson,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        
        // Assert
        Assert.True(response.IsSuccessStatusCode);
        Assert.NotNull(content);
        Assert.Equivalent(HttpStatusCode.OK, response.StatusCode);
        Assert.True(content.All(u => u.Id != user.Id));
    }
    
    [Theory]
    [InlineData("/api/user/delete/")]
    public async Task Delete_Needs_Admin_Role(string url)
    {
        // Act
        var response = await UnauthorizedClient.DeleteAsync(url + Guid.NewGuid());
        
        // Assert
        Assert.False(response.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.Unauthorized, response.StatusCode);
    }
    
    [Theory]
    [InlineData("/api/user/delete/")]
    public async Task Delete_Returns_NotFound(string url)
    {
        // Act
        var response = await UnauthorizedClient.DeleteAsync(url + Guid.NewGuid());
        
        // Assert
        Assert.False(response.IsSuccessStatusCode);
        Assert.Equivalent(HttpStatusCode.Unauthorized, response.StatusCode);
    }
}