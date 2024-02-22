using System.Net.Http.Json;
using Jaysbe.Contracts;

namespace Jaysbe.IntegrationTests.Bases;

public abstract class AuthBase
{
    protected readonly CustomWebApplicationFactory<Program> ApplicationFactory;
    protected readonly HttpClient Client;
    private readonly string Token;
    
    protected AuthBase(CustomWebApplicationFactory<Program> applicationFactory, string email, string password)
    {
        ApplicationFactory = applicationFactory;
        Client = applicationFactory.CreateClient();
        var content = JsonContent.Create(new AuthRequest(email, password));
        var response = Client.PostAsync("/api/auth/authenticate", content);
        response.Wait();
        
        var authHeader = response.Result.Headers
            .FirstOrDefault(header => header.Key == "Set-Cookie").Value;
        
        Token = authHeader.FirstOrDefault().Split("=")[1];
        Client.DefaultRequestHeaders.Add("Authorization", new []{ "Bearer " + Token });
    }
}