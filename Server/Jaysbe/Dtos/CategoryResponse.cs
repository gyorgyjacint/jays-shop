using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Jaysbe.Models;

namespace Jaysbe.Dtos;

public class CategoryResponse
{
    public Guid? CategoryId { get; init; }
    public string Name { get; set; }
    public Guid? ParentId { get; init; }
    public Category? Parent { get; init; }
    
    public Stack<CategoryParentInfo>? Parents
    {
        get
        {
            if (Parent == null)
                return null;
            var categoryStack = new Stack<CategoryParentInfo>();
            Category? examinable = Parent;

            do
            {
                categoryStack.Push(
                    new CategoryParentInfo { CategoryId = examinable.CategoryId, Name = examinable.Name });
                examinable = examinable.Parent;
            } while (examinable?.ParentId != null && examinable.Parent != null);
            
            return categoryStack.Count > 0 ? categoryStack : null;
        }
    }
}