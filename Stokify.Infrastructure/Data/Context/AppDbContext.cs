using Microsoft.EntityFrameworkCore;
using Stokify.Domain.Users;

namespace Stokify.Infrastructure.Data.Context;

public sealed class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost; Port=5432;Database=StokifyDb;Username=postgres;Password=postgres");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<Flunt.Notifications.Notification>();

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}