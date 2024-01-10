using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jaysbe.Models;


public record ProductDescOption
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid? ProductDescOptionId { get; init; }
    
    [MaxLength(70)]
    public string Name { get; set; }
    [MaxLength(150)]
    public string Option { get; set; }
}