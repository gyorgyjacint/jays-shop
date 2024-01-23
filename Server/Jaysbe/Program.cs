using System.Text;
using System.Text.Json.Serialization;
using Jaysbe.Data;
using Jaysbe.Infrastucture;
using Jaysbe.Services.Authentication;
using Jaysbe.Services.File;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

var imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
    builder.Configuration["ProductImageUploadPath"] ??
    throw new NullReferenceException("ProductImageUploadPath is not found in configuration"));
var imageAccessRoute = builder.Configuration["ImageAccessRoute"] ??
                       throw new NullReferenceException("ImageAccessRoute is not found in configuration");

if (!Directory.Exists(imagePath))
    Directory.CreateDirectory(imagePath);

AddServices();
ConfigureSwagger();
AddDbContext();
AddAuthentication();
AddIdentity();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(imagePath),
    RequestPath = imageAccessRoute 
});

app.UseExceptionHandler();

app.MapControllers();

AddRoles();
AddAdmin();

app.Run();

void AddServices()
{
    builder.Services.AddControllers()
        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        });
    builder.Services.AddEndpointsApiExplorer();

    builder.Services.AddScoped<IAuthService, AuthService>();
    builder.Services.AddScoped<ITokenService, TokenService>();
    builder.Services.AddScoped<IImageUploadHandler, ImageUploadHandler>();
    builder.Services.AddAutoMapper(typeof(Program).Assembly);

    builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
    builder.Services.AddProblemDetails();
}

void ConfigureSwagger()
{
    builder.Services.AddSwaggerGen(option =>
    {
        option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
        option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            In = ParameterLocation.Header,
            Description = "Please enter a valid token",
            Name = "Authorization",
            Type = SecuritySchemeType.Http,
            BearerFormat = "JWT",
            Scheme = "Bearer"
        });
        option.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                new string[] { }
            }
        });
    });
}

void AddDbContext()
{
    var connectionStr = builder.Configuration["ConnectionString"];

    builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionStr));
}

void AddAuthentication()
{
    var issueSign = builder.Configuration["IssueSign"];
    var issueAudience = builder.Configuration["IssueAudience"];
    var issuerSigningKey = builder.Configuration["IssuerSigningKey"];

    builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddCookie(options =>
        {
            options.Cookie.Name = "Authorization";
        })
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters()
            {
                ClockSkew = TimeSpan.Zero,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = issueAudience,
                ValidAudience = issueAudience,
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(issuerSigningKey ??
                                           throw new InvalidOperationException($"{nameof(issuerSigningKey)} is null"))
                ),
            };
            options.Events = new JwtBearerEvents
            {
                OnMessageReceived = context =>
                {
                    context.Token = context.Request.Cookies["Authorization"];
                    return Task.CompletedTask;
                }
            };
        });
}

void AddIdentity()
{
    builder.Services.AddIdentityCore<IdentityUser>(options =>
        {
            options.SignIn.RequireConfirmedAccount = false;
            options.User.RequireUniqueEmail = true;
            options.Password.RequireDigit = false;
            options.Password.RequiredLength = 6;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequireLowercase = false;
        })
        .AddRoles<IdentityRole>()
        .AddEntityFrameworkStores<AppDbContext>();
}

void AddRoles()
{
    using var scope = app.Services.CreateScope();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    var tAdmin = CreateAdminRole(roleManager);
    tAdmin.Wait();

    var tUser = CreateUserRole(roleManager);
    tUser.Wait();
}

async Task CreateAdminRole(RoleManager<IdentityRole> roleManager)
{
    await roleManager.CreateAsync(new IdentityRole("Admin"));
}

async Task CreateUserRole(RoleManager<IdentityRole> roleManager)
{
    await roleManager.CreateAsync(new IdentityRole("User"));
}

void AddAdmin()
{
    var tAdmin = CreateAdminIfNotExists();
    tAdmin.Wait();
}

async Task CreateAdminIfNotExists()
{
    using var scope = app.Services.CreateScope();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
    var adminInDb = await userManager.FindByEmailAsync(builder.Configuration["AdminEmail"]);
    if (adminInDb == null)
    {
        var admin = new IdentityUser { UserName = "admin", Email = builder.Configuration["AdminEmail"] };
        var adminCreated = await userManager.CreateAsync(admin, builder.Configuration["AdminPw"]);

        if (adminCreated.Succeeded)
        {
            await userManager.AddToRoleAsync(admin, "Admin");
        }
    }
}