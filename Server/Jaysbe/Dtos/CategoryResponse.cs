using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Jaysbe.Models;

namespace Jaysbe.Dtos;

public class CategoryResponse
{
    public CategoryResponse(Category category)
    {
        Name = category.Name;
        Parent = category.Parent;
        CategoryId = category.CategoryId;
        ParentId = category.ParentId;
    }

    public CategoryResponse()
    { }
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid? CategoryId { get; init; }
    [MaxLength(70)]
    public string Name { get; set; }
    [JsonIgnore]
    [ForeignKey("Category")]
    public Guid? ParentId { get; set; }
    [JsonIgnore]
    public Category? Parent { get; set; }
    
    public Stack<CategoryBase>? Parents => GetParents();

    protected virtual Stack<CategoryBase>? GetParents()
    {
        if (Parent == null)
            return null;

        var categoryStack = new Stack<CategoryBase>();
        Category? examinable = Parent;

        while (examinable != null)
        {
            categoryStack.Push(
                new CategoryBase { CategoryId = examinable.CategoryId, Name = examinable.Name });
            examinable = examinable.Parent;
        }

        return categoryStack.Count > 0 ? categoryStack : null;
    }
}