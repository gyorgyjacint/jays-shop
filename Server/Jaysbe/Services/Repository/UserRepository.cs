using AutoMapper;
using Jaysbe.Controllers;
using Jaysbe.Data;
using Jaysbe.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Jaysbe.Services.Repository;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger<UserController> _logger;
    private readonly IMapper _mapper;

    public UserRepository(AppDbContext context, ILogger<UserController> logger, IMapper mapper)
    {
        _context = context;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<UserDto<Guid>[]> GetAll()
    {
        var identityUsers = _context.Users;
        
        var users = await identityUsers.Select(u => _mapper.Map<UserDto<Guid>>(u)).ToArrayAsync();
        
        _logger.LogInformation($"Users found: [{users.Length}]");
        return users;
    }

    public async Task<string?> Delete(Guid id)
    {
        _logger.LogInformation($"Attempting to delete user with ID: [{id}]");
        //TODO distinguish errors?
        
        var user = _context.Users.FirstOrDefault(u => u.Id == id.ToString());
        if (user is null)
            return null;
        
        var adminRole = _context.Roles.FirstOrDefault(r => r.Name != null && r.Name.ToLower() == "admin");
        var role = _context.UserRoles.FirstOrDefault(r => r.UserId == user.Id);
        
        if (adminRole == null || role == null || role.RoleId == adminRole.Id)
        {
            return null;
        }
        
        if (user.Id == id.ToString())
        {
            _context.Remove(user);
        }
        else
        {
            _logger.LogInformation($"User not found, ID: [{id}]");
            return null;
        }

        await _context.SaveChangesAsync();
        _logger.LogInformation($"User removed, ID: [{user.Id}]");

        return user.Id;
    }

    public async Task<string?> Update(UserDto<string> model)
    {
        var identityUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == model.Id);
        
        if (identityUser is null)
        {
            _logger.LogInformation($"{nameof(model)} is null");
            return null;
        }

        identityUser.UserName = model.UserName;
        identityUser.NormalizedUserName = model.UserName?.ToUpper();
        identityUser.Email = model.Email;
        identityUser.NormalizedEmail = model.Email?.ToUpper();
        identityUser.EmailConfirmed = model.EmailConfirmed;
        identityUser.PhoneNumber = model.PhoneNumber;
        identityUser.PhoneNumberConfirmed = model.PhoneNumberConfirmed;
        identityUser.SecurityStamp = Guid.NewGuid().ToString();

        await _context.SaveChangesAsync();
        _logger.LogInformation($"User [{identityUser.Id}] updated");

        return identityUser.Id;
    }
}