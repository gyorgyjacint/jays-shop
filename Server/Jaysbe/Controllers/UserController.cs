using AutoMapper;
using Jaysbe.Data;
using Jaysbe.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jaysbe.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
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
    public async Task<User<Guid>[]> GetAll()
    {
        _logger.LogInformation(nameof(GetAll));
        var identityUsers = _context.Users;
        
        var users = await identityUsers.Select(u => _mapper.Map<User<Guid>>(u)).ToArrayAsync();
        
        _logger.LogInformation($"Users found: [{users.Length}]");
        return users;
    }
}