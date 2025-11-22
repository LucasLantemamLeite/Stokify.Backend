using Stokify.Domain.Entities;

namespace Stokify.Application.Abstracts.Contracts.Queries;

public interface IUserQuery : IQuery<User>
{
    Task<IEnumerable<User>> GetByNameAsync(string name);
    Task<User?> GetByEmailAsync(string email);
    Task<User?> GetByPhoneAsync(string phone);
    Task<IEnumerable<User>> GetByAccessAsync(sbyte access);
    Task<IEnumerable<User>> GetByCreatedAtAsync(DateTime created);
    Task<IEnumerable<User>> GetByUpdatedAtAsync(DateTime updated);
    Task<IEnumerable<User>> GetByActiveAsync(bool active);
    Task<bool> EmailInUseAsync(string email);
    Task<bool> PhoneInUseAsync(string phone);
}