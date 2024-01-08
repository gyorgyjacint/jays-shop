using Jaysbe.Models;
using Microsoft.EntityFrameworkCore;

namespace Jaysbe.Data;

public class AppContext : DbContext
{
    public DbSet<Item> Items { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<SubCategory> SubCategories { get; set; }

    public AppContext(DbContextOptions<AppContext> options) : base(options)
    {
    }
}