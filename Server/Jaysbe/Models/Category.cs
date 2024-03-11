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
    
    [ForeignKey("Category")]
    public Guid? ParentId { get; set; }
    public Category? Parent { get; set; }
    
    /*
    [NotMapped]
    public string[]? Parents
    {
        get
        {
            var q = new Stack<Category>();
            Category examinable = this;
            
            while (examinable.ParentId != null && examinable.Parent != null)
            {
                q.Push(examinable.Parent);
                examinable = examinable.Parent;
            }

            var res = q.Select(c => c.Name);
            
            return q.Count > 0 ? res.ToArray() : null;
        }
    }
    //public IEnumerable<SubCategory>? SubCategories { get; set; }*/
}
