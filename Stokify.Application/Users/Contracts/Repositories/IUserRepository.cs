using Stokify.Application.Shared.Contracts;
using Stokify.Domain.Users;

namespace Stokify.Application.Users.Contracts.Repositories;

public interface IUserRepository : IRepository<User>
{
    void CreateAsync(User user);
    void DeleteAsync(User user);
    void UpdateAsync(User user);
    Task<User?> GetByIdAsync(Guid id);
    Task<bool> EmailInUseAsync(string email);
    Task<bool> PhoneInUseAsync(string phone);
}