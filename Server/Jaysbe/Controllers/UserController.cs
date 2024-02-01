using AutoMapper;
using Jaysbe.Data;
using Jaysbe.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jaysbe.Controllers;

[ApiController]
[Route("api/[controller]/[action]/")]
public class UserController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly ILogger<UserController> _logger;
    private readonly IMapper _mapper;

    public UserController(AppDbContext context, ILogger<UserController> logger, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
        _logger = logger;
    }

    [Authorize(Roles = "Admin")]
    [HttpGet]
    public async Task<UserDto<Guid>[]> GetAll()
    {
        _logger.LogInformation(nameof(GetAll));
        var identityUsers = _context.Users;
        
        var users = await identityUsers.Select(u => _mapper.Map<UserDto<Guid>>(u)).ToArrayAsync();
        
        _logger.LogInformation($"Users found: [{users.Length}]");
        return users;
    }
    
    [Authorize(Roles = "Admin")]
    [HttpGet("{userId}")]
    public async Task<IActionResult> Delete([FromRoute] string userId)
    {
        _logger.LogInformation(nameof(Delete));
        _logger.LogInformation($"Attempting to delete user with ID: [{userId}]");
        
        var user = _context.Users.FirstOrDefault(u => u.Id == userId);
        if (user is null)
            return NotFound(userId);
        
        var adminRole = _context.Roles.FirstOrDefault(r => r.Name != null && r.Name.ToLower() == "admin");
        var role = _context.UserRoles.FirstOrDefault(r => r.UserId == user.Id);

        if (adminRole == null || role == null || role.RoleId == adminRole.Id)
        {
            return Unauthorized();
        }
        
        if (user.Id == userId)
        {
            _context.Remove(user);
        }
        else
        {
            _logger.LogInformation($"User not found, ID: [{userId}]");
            return NotFound(userId);
        }

        await _context.SaveChangesAsync();
        _logger.LogInformation($"User removed, ID: [{user.Id}]");
        
        return Ok(user.Id);
    }

    [Authorize(Roles = "Admin")]
    [HttpPatch]
    public async Task<IActionResult> Update([FromBody]UserDto<Guid> user)
    {
        _logger.LogInformation(nameof(Update));
        var identityUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == user.Id.ToString());
        
        if (identityUser is null)
        {
            _logger.LogInformation($"{nameof(user)} is null");
            return NotFound();
        }

        identityUser.UserName = user.UserName;
        identityUser.NormalizedUserName = user.UserName?.ToUpper();
        identityUser.Email = user.Email;
        identityUser.NormalizedEmail = user.Email?.ToUpper();
        identityUser.EmailConfirmed = user.EmailConfirmed;
        identityUser.PhoneNumber = user.PhoneNumber;
        identityUser.PhoneNumberConfirmed = user.PhoneNumberConfirmed;
        identityUser.SecurityStamp = Guid.NewGuid().ToString();

        await _context.SaveChangesAsync();
        _logger.LogInformation($"User [{identityUser.Id}] updated");

        return Ok(identityUser.Id);
    }
}