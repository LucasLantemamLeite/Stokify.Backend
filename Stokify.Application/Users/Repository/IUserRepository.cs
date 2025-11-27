using Stokify.Application.Abstractions.Contracts;
using Stokify.Domain.Users;

namespace Stokify.Application.Users.Repository;

public interface IUserRepository : IRepository<User>
{
    Task<bool> EmailInUseAsync(string email);
    Task<bool> PhoneInUseAsync(string phone);
}