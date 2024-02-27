using Jaysbe.Models;

namespace Jaysbe.IntegrationTests.Models;

public class ProductTestRequest
{
    public string Name { get; set; }
    public string? Brand { get; set; }
    
    public decimal Price { get; set; }
    public decimal? DiscountPrice { get; set; }
    public UInt16 Quantity { get; set; }

    public string Description { get; set; }
    public string? Color { get; set; }
    public IEnumerable<ProductDescOption>? ProductDescriptions { get; set; }
    
    public BinaryData Thumbnail { get; set; }
    public ICollection<BinaryData>? Pictures { get; set; }
    
    public Category? Category { get; set; }
}