using Jaysbe.Models;
using Microsoft.EntityFrameworkCore;

namespace Jaysbe.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product>? Products { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<SubCategory>? SubCategories { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}