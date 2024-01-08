using System.ComponentModel.DataAnnotations;

namespace Jaysbe.Models;

public class SubCategory
{
    public Guid SubCategoryId { get; init; }
    [MaxLength(70)]
    public string Name { get; set; }
}