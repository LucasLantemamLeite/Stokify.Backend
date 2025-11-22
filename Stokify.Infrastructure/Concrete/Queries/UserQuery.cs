using Microsoft.EntityFrameworkCore;
using Stokify.Application.Abstracts.Contracts.Queries;
using Stokify.Domain.Entities;
using Stokify.Infrastructure.Data.Context;

namespace Stokify.Infrastructure.Concrete.Queries;

public sealed class UserQuery(AppDbContext context) : IUserQuery
{
    public async Task<bool> EmailInUseAsync(string email)
        => await context.Users.AnyAsync(u => u.Email.Value == email);

    public async Task<IEnumerable<User>> GetByAccessAsync(sbyte access)
        => await context.Users.AsNoTracking().Where(u => (sbyte)u.Access.Value == access).ToListAsync();

    public async Task<IEnumerable<User>> GetByActiveAsync(bool active)
        => await context.Users.AsNoTracking().Where(u => u.Active.Value == active).ToListAsync();

    public async Task<IEnumerable<User>> GetByCreatedAtAsync(DateTime created)
        => await context.Users.AsNoTracking().Where(u => u.CreatedAt.Value == created).ToListAsync();

    public async Task<User?> GetByEmailAsync(string email)
        => await context.Users.SingleOrDefaultAsync(u => u.Email.Value == email);

    public async Task<User?> GetByIdAsync(Guid id)
        => await context.Users.SingleOrDefaultAsync(u => u.Id == id);

    public async Task<IEnumerable<User>> GetByNameAsync(string name)
        => await context.Users.AsNoTracking().Where(u => u.Name.Value == name).ToListAsync();

    public async Task<User?> GetByPhoneAsync(string phone)
     => await context.Users.SingleOrDefaultAsync(u => u.Phone.Value == phone);

    public async Task<IEnumerable<User>> GetByUpdatedAtAsync(DateTime updated)
        => await context.Users.AsNoTracking().Where(u => u.UpdatedAt.Value == updated).ToListAsync();

    public async Task<bool> PhoneInUseAsync(string phone)
        => await context.Users.AnyAsync(u => u.Phone.Value == phone);
}