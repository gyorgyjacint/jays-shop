using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jaysbe.Models;

public class Label
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid LabelId { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
}