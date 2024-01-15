using System.ComponentModel.DataAnnotations;
using Jaysbe.Models;
using Microsoft.EntityFrameworkCore;

namespace Jaysbe.Contracts;

public class ProductRequest
{
    [MaxLength(70)]
    public string Name { get; set; }
    [MaxLength(70)]
    public string? Brand { get; set; }
    
    [Precision(16, 2)]
    public decimal Price { get; set; }
    [Precision(16, 2)]
    public decimal? DiscountPrice { get; set; }
    public UInt16 Quantity { get; set; }

    [MaxLength(500)]
    public string Description { get; set; }
    [MaxLength(40)]
    public string? Color { get; set; }
    public IEnumerable<ProductDescOption>? ProductDescriptions { get; set; }
    
    public IFormFile Thumbnail { get; set; }
    public ICollection<IFormFile>? Pictures { get; set; }
    
    public Category? Category { get; set; }
}