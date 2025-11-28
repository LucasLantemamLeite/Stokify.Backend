using Microsoft.EntityFrameworkCore;
using Stokify.Application.Users.Contracts.Repositories;
using Stokify.Domain.Users;
using Stokify.Infrastructure.Data.Context;

namespace Stokify.Infrastructure.Users.Repository;

public sealed class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    public UserRepository(AppDbContext context)
        => _context = context;

    // Write
    public async Task CreateAsync(User entity)
        => await _context.Users.AddAsync(entity);

    public async Task DeleteAsync(User entity)
        => _context.Users.Remove(entity);

    public async Task UpdateAsync(User entity)
        => _context.Users.Update(entity);

    // Read
    public async Task<bool> EmailInUseAsync(string email)
        => await _context.Users.AnyAsync(u => u.Email.Value == email);

    public async Task<User?> GetByIdAsync(Guid id)
        => await _context.Users.SingleOrDefaultAsync(u => u.Id == id);

    public async Task<bool> PhoneInUseAsync(string phone)
        => await _context.Users.AnyAsync(u => u.Phone.Value == phone);
}