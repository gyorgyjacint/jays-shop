using System.Net.Http.Json;
using Jaysbe.Contracts;

namespace Jaysbe.IntegrationTests.Bases;

public abstract class AuthBase
{
    protected readonly CustomWebApplicationFactory<Program> ApplicationFactory;
    protected readonly HttpClient AuthorizedClient;
    protected readonly HttpClient UnauthorizedClient;

    protected AuthBase(CustomWebApplicationFactory<Program> applicationFactory, string email, string password)
    {
        ApplicationFactory = applicationFactory;
        AuthorizedClient = applicationFactory.CreateClient();
        UnauthorizedClient = applicationFactory.CreateClient();

        var response = GetAuthResponse(email, password);
        var token = ExtractToken(response);
        
        AuthorizedClient.DefaultRequestHeaders.Add("Authorization", new []{ "Bearer " + token });
    }

    private Task<HttpResponseMessage> GetAuthResponse(string email, string password)
    {
        var content = JsonContent.Create(new AuthRequest(email, password));
        return AuthorizedClient.PostAsync("/api/auth/authenticate", content);
    }

    private string ExtractToken(Task<HttpResponseMessage> response)
    {
        response.Wait();
        var authHeader = response.Result.Headers
            .FirstOrDefault(header => header.Key == "Set-Cookie").Value;
        
        return authHeader.FirstOrDefault().Split("=")[1];
    }
}