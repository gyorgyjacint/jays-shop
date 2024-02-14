using Jaysbe.Models;

namespace Jaysbe.Services.Repository;

public interface ICategoryRepository
{
    public Task<Category[]> GetAll();
    public Task<Guid?> Add(Category model);
    public Task<Guid?> Delete(Guid id);
}