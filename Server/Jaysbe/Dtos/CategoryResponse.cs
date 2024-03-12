using Jaysbe.Models;

namespace Jaysbe.Dtos;

public class CategoryResponse : Category
{
    public CategoryResponse(Category category)
    {
        Name = category.Name;
        Parent = category.Parent;
        CategoryId = category.CategoryId;
        ParentId = category.ParentId;
    }
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