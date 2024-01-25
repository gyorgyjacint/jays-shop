using Jaysbe.Models;

namespace Jaysbe.Contracts;

public class ProductResponse
{
    public Guid? ProductId { get; init; }
    public uint? ProductNumber { get; set; }
    
    public string Name { get; set; }
    public string? Brand { get; set; }
    
    public decimal Price { get; set; }
    public decimal? DiscountPrice { get; set; }
    public int Quantity { get; set; }

    public string Description { get; set; }
    public string? Color { get; set; }
    public IEnumerable<ProductDescOption>? ProductDescriptions { get; set; }
    
    public byte[] ThumbnailBytes { get; set; }
    public IList<byte[]>? PicturesBytes { get; set; }
    
    public Category? Category { get; set; }
}