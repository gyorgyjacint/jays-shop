using Jaysbe.Dtos;
using Jaysbe.Models;

namespace Jaysbe.Services.Repository;

public interface ICategoryRepository
{
    public Task<CategoryResponse[]> GetAll();
    public Task<Guid?> Add(Category model);
    public Task<Guid?> Delete(Guid id);
    public Task<Guid?> UpdateOrAdd(Category model);

}