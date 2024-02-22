using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Jaysbe.Contracts;

namespace Jaysbe.IntegrationTests.Controllers;

[Collection("tests")]
public class AuthControllerTests : IClassFixture<CustomWebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public AuthControllerTests(CustomWebApplicationFactory<Program> applicationFactory)
    {
        _client = applicationFactory.CreateClient();
    }

    #region Register

    [Theory]
    [InlineData("/api/auth/register")]
    public async Task Register_IsSuccessful(string url)
    {
        // Arrange
        var regData = new RegistrationRequest("test1@test.com", "test1", "test1pw");
        var content = JsonContent.Create(regData);
        
        // Act
        var responseMessage = await _client.PostAsync(url, content);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.True(responseMessage.IsSuccessStatusCode);
            Assert.True(responseMessage.StatusCode == HttpStatusCode.Created);
        });
    }
    
    [Theory]
    [InlineData("/api/auth/register")]
    public async Task Register_Returns_Correct_Data_OnSuccessful(string url)
    {
        // Arrange
        var regData = new RegistrationRequest("test2@test.com", "test2", "test2pw");
        var content = JsonContent.Create(regData);
        var jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
            
        // Act
        var responseMessage = await _client.PostAsync(url, content);
        var json = await responseMessage.Content.ReadAsStringAsync();
        var responseData = JsonSerializer.Deserialize<RegistrationResponse>(json, jsonOptions);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.True(responseMessage.IsSuccessStatusCode);
            Assert.True(responseMessage.StatusCode == HttpStatusCode.Created);
            Assert.Equivalent(regData.Email, responseData?.Email);
            Assert.Equivalent(regData.UserName, responseData?.UserName);
        });
    }
    
    [Theory]
    [InlineData("/api/auth/register")]
    public async Task Register_Returns_Error_With_Unavailable_Email(string url)
    {
        // Arrange
        var regData = new RegistrationRequest("test1@test.com", "test1", "test1pw");
        var content = JsonContent.Create(regData);
            
        // Act
        var responseMessage = await _client.PostAsync(url, content);

        // Assert
        Assert.False(responseMessage.IsSuccessStatusCode);
    }
    
    [Theory]
    [InlineData("/api/auth/register")]
    public async Task Register_Returns_Error_With_Unavailable_UserName(string url)
    {
        // Arrange
        var regData = new RegistrationRequest("test4@test.com", "test1", "test4pw");
        var content = JsonContent.Create(regData);
            
        // Act
        var responseMessage = await _client.PostAsync(url, content);

        // Assert
        Assert.False(responseMessage.IsSuccessStatusCode);
    }
    
    [Theory]
    [InlineData("/api/auth/register")]
    public async Task Register_Returns_Error_With_Incorrect_Email(string url)
    {
        // Arrange
        var regData = new RegistrationRequest("test1_at_test_dot_com", "test1", "test1pw");
        var content = JsonContent.Create(regData);
            
        // Act
        var responseMessage = await _client.PostAsync(url, content);

        // Assert
        Assert.False(responseMessage.IsSuccessStatusCode);
    }
    
    [Theory]
    [InlineData("/api/auth/register")]
    public async Task Register_Returns_Error_With_Incorrect_Password(string url)
    {
        // Arrange
        var regData = new RegistrationRequest("test5@test.com", "test5", "12345");
        var content = JsonContent.Create(regData);
            
        // Act
        var responseMessage = await _client.PostAsync(url, content);

        // Assert
        Assert.False(responseMessage.IsSuccessStatusCode);
    }
    
    #endregion

    #region Authenticate
    
    [Theory]
    [InlineData("/api/auth/authenticate")]
    public async Task Authenticate_Returns_SetCookie_Headers(string url)
    {
        // Arrange
        var authData = new AuthRequest("test1@test.com", "test1pw");
        var content = JsonContent.Create(authData);
            
        // Act
        var responseMessage = await _client.PostAsync(url, content);

        // Assert
        var setCookieHeaders = responseMessage.Headers.SingleOrDefault(header => header.Key == "Set-Cookie").Value;
        Assert.NotEmpty(setCookieHeaders);
    }
    
    [Theory]
    [InlineData("/api/auth/authenticate")]
    public async Task Authenticate_Returns_Email_And_UserName(string url)
    {
        // Arrange
        var authData = new AuthRequest("test1@test.com", "test1pw");
        var content = JsonContent.Create(authData);
        var jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
            
        // Act
        var responseMessage = await _client.PostAsync(url, content);
        var json = await responseMessage.Content.ReadAsStringAsync();
        var responseData = JsonSerializer.Deserialize<AuthResponse>(json, jsonOptions);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.Equivalent(authData.Email, responseData?.Email);
            Assert.Equivalent("test1", responseData?.UserName);
        });
    }
    
    [Theory]
    [InlineData("/api/auth/authenticate")]
    [InlineData("/api/auth/authenticateadmin")]
    public async Task Authenticate_Returns_Error_With_Invalid_Email(string url)
    {
        // Arrange
        var authData = new AuthRequest("test1test.com", "test1pw");
        var content = JsonContent.Create(authData);
            
        // Act
        var responseMessage = await _client.PostAsync(url, content);

        // Assert
        Assert.False(responseMessage.IsSuccessStatusCode);
    }
    
    [Theory]
    [InlineData("/api/auth/authenticate")]
    public async Task Authenticate_Returns_Error_With_Invalid_Password(string url)
    {
        // Arrange
        var authData = new AuthRequest("test1@test.com", "invalid password");
        var content = JsonContent.Create(authData);
            
        // Act
        var responseMessage = await _client.PostAsync(url, content);

        // Assert
        Assert.False(responseMessage.IsSuccessStatusCode);
    }
    
    // admin
    [Theory]
    [InlineData("/api/auth/authenticateadmin")]
    public async Task AuthenticateAdmin_Returns_Error_With_Invalid_Password(string url)
    {
        // Arrange
        var authData = new AuthRequest("admin@admin.com", "invalid password");
        var content = JsonContent.Create(authData);
            
        // Act
        var responseMessage = await _client.PostAsync(url, content);

        // Assert
        Assert.False(responseMessage.IsSuccessStatusCode);
    }
    
    #endregion

}