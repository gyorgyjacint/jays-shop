using System.ComponentModel.DataAnnotations;

namespace Jaysbe.Models;


public record ItemDescOption
{
    public Guid ItemDescOptionId { get; init; }
    
    [MaxLength(70)]
    public string Name { get; set; }
    [MaxLength(150)]
    public string Option { get; set; }
}