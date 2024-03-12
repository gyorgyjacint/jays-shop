using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Jaysbe.Models;

public class Category : CategoryBase
{
    [JsonIgnore]
    [ForeignKey("Category")]
    public Guid? ParentId { get; set; }
    [JsonIgnore]
    public Category? Parent { get; set; }
}
