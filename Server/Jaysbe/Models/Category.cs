using System.ComponentModel.DataAnnotations;

namespace Jaysbe.Models;

public class Category
{
    public Guid CategoryId { get; init; }
    [MaxLength(70)]
    public string Name { get; set; }
    public IEnumerable<SubCategory> SubCategories { get; set; }
}
