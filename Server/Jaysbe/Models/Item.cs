using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jaysbe.Models;

public class Item
{
    public Guid ItemId { get; init; }
    public int ItemNumber { get; set; }
    
    [MaxLength(70)]
    public string Name { get; set; }
    [MaxLength(70)]
    public string? Brand { get; set; }
    
    [Precision(16, 2)]
    public decimal Price { get; set; }
    [Precision(16, 2)]
    public decimal? DiscountPrice { get; set; }
    public int Quantity { get; set; }
    
    [MaxLength(500)]
    public string Description { get; set; }
    [MaxLength(40)]
    public string? Color { get; set; }
    public IEnumerable<ItemDescOption> ItemDescriptions { get; set; }
    
    [MaxLength(150)]
    public string ThumbnailUrl { get; set; }
    public IEnumerable<string> PicturesUrls { get; set; }
    
    public Category Category { get; set; }
}