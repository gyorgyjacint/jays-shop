using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Jaysbe.Contracts;

namespace Jaysbe.IntegrationTests.Controllers;

[Collection("auth")]
public class AuthControllerTests : IClassFixture<CustomWebApplicationFactory<Jaysbe.Program>>
{
    private readonly CustomWebApplicationFactory<Jaysbe.Program> _applicationFactory;

    public AuthControllerTests(CustomWebApplicationFactory<Program> applicationFactory)
    {
        _applicationFactory = applicationFactory;
    }

    [Theory]
    [InlineData("/api/auth/register")]
    public async Task Register_IsSuccessful(string url)
    {
        // Arrange
        var client = _applicationFactory.CreateClient();
        var regData = new RegistrationRequest("test1@test.com", "test1", "test1pw");
        var content = JsonContent.Create(regData);
        
        // Act
        var regEvent = await client.PostAsync(url, content);

        // Assert
        
        Assert.Multiple(() =>
        {
            Assert.True(regEvent.IsSuccessStatusCode);
            Assert.True(regEvent.StatusCode == HttpStatusCode.Created);
        });
    }
    
    [Theory]
    [InlineData("/api/auth/register")]
    public async Task Register_Returns_Correct_Data_OnSuccessful(string url)
    {
        // Arrange
        var client = _applicationFactory.CreateClient();
        var regData = new RegistrationRequest("test2@test.com", "test2", "test2pw");
        var content = JsonContent.Create(regData);
        var jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
            
        // Act
        var regEvent = await client.PostAsync(url, content);
        var json = await regEvent.Content.ReadAsStringAsync();
        var responseData = JsonSerializer.Deserialize<RegistrationResponse>(json, jsonOptions);

        // Assert
        
        Assert.Multiple(() =>
        {
            Assert.True(regEvent.IsSuccessStatusCode);
            Assert.True(regEvent.StatusCode == HttpStatusCode.Created);
            Assert.Equivalent(regData.Email, responseData?.Email);
            Assert.Equivalent(regData.UserName, responseData?.UserName);
        });
    }
}