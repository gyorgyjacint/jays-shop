using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jaysbe.Models;

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid? ProductId { get; init; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public uint? ProductNumber { get; set; }
    
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
    public IEnumerable<ProductDescOption>? ProductDescriptions { get; set; }
    
    [MaxLength(150)]
    public string? ThumbnailUrl { get; set; }
    public List<string>? PicturesUrls { get; set; }
    
    public List<Label> Labels { get; set; }
}