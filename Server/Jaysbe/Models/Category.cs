using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jaysbe.Models;

public class Category
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid? CategoryId { get; init; }
    
    [MaxLength(70)]
    public string Name { get; set; }
    public IEnumerable<SubCategory>? SubCategories { get; set; }
}
