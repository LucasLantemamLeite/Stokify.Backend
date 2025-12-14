using Stokify.Application.Shared.Contracts;
using Stokify.Domain.Users;

namespace Stokify.Application.Users.Contracts.Repositories;

public interface IUserRepository : IRepository<User>
{
    void Create(User user);
    void Delete(User user);
    void Update(User user);
    Task<User?> GetByIdAsync(Guid id);
    Task<bool> EmailInUseAsync(string email);
    Task<bool> PhoneInUseAsync(string phone);
}