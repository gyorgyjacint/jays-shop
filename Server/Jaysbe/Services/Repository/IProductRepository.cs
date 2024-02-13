using Jaysbe.Contracts;
using Jaysbe.Dtos;
using Jaysbe.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Jaysbe.Services.Repository;

public interface IProductRepository
{
    public Task<Product[]> GetAll();
    public Task<Product?> GetById(Guid id);
    public Task<bool> Remove(Guid id);
    public Task<Guid?> Add(ProductRequestDto model, ModelStateDictionary modelState);
    public Task<Guid?> Update(ProductUpdateRequest model, ModelStateDictionary modelState);
}