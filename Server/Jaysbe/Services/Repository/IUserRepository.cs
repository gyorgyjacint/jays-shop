using Jaysbe.Dtos;

namespace Jaysbe.Services.Repository;

public interface IUserRepository
{
    public Task<UserDto<Guid>[]> GetAll();
    public Task<string?> Delete(Guid id);
    public Task<string?> Update(UserDto<string> model);
    public Task<UserDto<Guid>?> GetById(string id);
}