using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Jaysbe.Models;

public class Category
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid? CategoryId { get; init; }
    [MaxLength(70)]
    public string Name { get; set; }
    [ForeignKey("Category")]
    public Guid? ParentId { get; set; }
    [JsonIgnore]
    public Category? Parent { get; set; }
}
