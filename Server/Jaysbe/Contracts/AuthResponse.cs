namespace Jaysbe.Contracts;

public record AuthResponse(string Email, string UserName, string? Token);