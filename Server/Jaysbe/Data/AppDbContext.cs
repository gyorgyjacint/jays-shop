using System.Diagnostics;
using Jaysbe.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Jaysbe.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : IdentityDbContext<IdentityUser, IdentityRole, string>(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<SubCategory> SubCategories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Category>()
            .HasIndex(e => e.Name)
            .IsUnique();

        var env = this.GetService<IWebHostEnvironment>();

        if (!env.IsDevelopment())
            return;
        
        // Seeds
        
        Debug.WriteLine($"[{nameof(OnModelCreating)}]: Development environment, seeding database");
        
        var hasher = new PasswordHasher<IdentityUser>();
        var testRoleId = Guid.NewGuid().ToString();

        builder.Entity<IdentityRole>().HasData(new IdentityRole
            { Id = testRoleId, Name = "TestUser", NormalizedName = "TESTUSER" });

        var hashedPassword = hasher.HashPassword(null, "asdasd");
        var users = new List<IdentityUser>();

        for (int i = 1; i <= 10; i++)
        {
            users.Add(
                new IdentityUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = $"user{i}",
                    NormalizedUserName = $"USER{i}",
                    Email = $"user{i}@user.com",
                    NormalizedEmail = $"USER{i}@USER.COM",
                    PasswordHash = hashedPassword,
                });
        }

        foreach (var user in users)
        {
            builder.Entity<IdentityUser>().HasData(user);
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = testRoleId,
                    UserId = user.Id
                });
        }
    }

    
}