using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jaysbe.Models;

public class SubCategory
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid? SubCategoryId { get; init; }
    
    [MaxLength(70)]
    public string Name { get; set; }
}