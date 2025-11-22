using Stokify.Application.Abstracts.Contracts.Repositories;
using Stokify.Domain.Entities;
using Stokify.Infrastructure.Data.Context;

namespace Stokify.Infrastructure.Concrete.Repositories;

public sealed class UserRepository(AppDbContext context) : IUserRepository
{
    public async Task CreateAsync(User entity)
        => await context.Users.AddAsync(entity);

    public async Task DeleteAsync(User entity)
        => context.Users.Remove(entity);

    public async Task UpdateAsync(User entity)
        => context.Users.Update(entity);
}