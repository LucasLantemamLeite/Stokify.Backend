using Stokify.Application.Shared.Contracts.Repositories;
using Stokify.Domain.Users;

namespace Stokify.Application.Users.Contracts.Repositories;

public interface IUserRepository : IRepository<User>
{
    Task<bool> EmailInUseAsync(string email);
    Task<bool> PhoneInUseAsync(string phone);
}