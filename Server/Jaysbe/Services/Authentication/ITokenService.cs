using Microsoft.AspNetCore.Identity;

namespace Jaysbe.Services.Authentication;

public interface ITokenService
{
    public string CreateToken(IdentityUser user, string role);

}