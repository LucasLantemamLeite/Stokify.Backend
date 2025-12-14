using Microsoft.EntityFrameworkCore;
using Stokify.Application.Users.Contracts.Repositories;
using Stokify.Domain.Users;
using Stokify.Infrastructure.Data.Context;

namespace Stokify.Infrastructure.Users.Repositories;

public sealed class UserRepository(AppDbContext context) : IUserRepository
{
    public void Create(User user)
        => context.Users.Add(user);

    public void Delete(User user)
        => context.Users.Remove(user);

    public void Update(User user)
        => context.Users.Update(user);

    public async Task<User?> GetByIdAsync(Guid id)
        => await context.Users.SingleOrDefaultAsync(x => x.Id == id);

    public async Task<bool> EmailInUseAsync(string email)
        => await context.Users.AnyAsync(x => x.Email == email);

    public async Task<bool> PhoneInUseAsync(string phone)
        => await context.Users.AnyAsync(x => x.Phone == phone);
}