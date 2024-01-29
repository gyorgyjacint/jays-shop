using Microsoft.AspNetCore.Identity;

namespace Jaysbe.Dtos;

public class UserDto<TKey> where TKey : IEquatable<TKey>
{
    [PersonalData] 
    public virtual TKey Id { get; set; } = default!;
    [ProtectedPersonalData]
    public virtual string? UserName { get; set; }
    [ProtectedPersonalData]
    public virtual string? Email { get; set; }
    [PersonalData]
    public virtual bool EmailConfirmed { get; set; }
    [ProtectedPersonalData]
    public virtual string? PhoneNumber { get; set; }
    [PersonalData]
    public virtual bool PhoneNumberConfirmed { get; set; }
    
}