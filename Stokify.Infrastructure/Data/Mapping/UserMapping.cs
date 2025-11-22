using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stokify.Domain.Entities;

namespace Stokify.Infrastructure.Data.Mapping;

public sealed class UserMapping : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.Id)
            .HasColumnName("Id")
            .HasColumnType("uuid")
            .IsRequired();

        builder.Property(u => u.Name)
            .HasColumnName("Name")
            .HasColumnType("varchar(100)")
            .HasConversion(v => v.Value, v => new(v, "Usuário"))
            .IsRequired();

        builder.Property(u => u.Email)
            .HasColumnName("Email")
            .HasColumnType("varchar(255)")
            .HasConversion(v => v.Value, v => new(v))
            .IsRequired();

        builder.HasIndex(u => u.Email, "Unique_Key_Email_Users")
            .IsUnique();

        builder.Property(u => u.Phone)
            .HasColumnName("Phone")
            .HasColumnType("varchar(15)")
            .HasConversion(v => v.Value, v => new(v))
            .IsRequired();

        builder.HasIndex(x => x.Phone, "Unique_Key_Phone_Users")
            .IsUnique();

        builder.Property(x => x.Password)
            .HasColumnName("PasswordHash")
            .HasColumnType("varchar(255)")
            .HasConversion(v => v.Value, v => new(v))
            .IsRequired();

        builder.Property(x => x.Access)
            .HasColumnName("Access")
            .HasColumnType("smallint")
            .HasConversion(v => v.Value, v => new((sbyte)v))
            .IsRequired();

        builder.Property(x => x.CreatedAt)
            .HasColumnName("CreatedAt")
            .HasColumnType("timestamptz")
            .HasConversion(v => v.Value, v => new(v))
            .IsRequired();

        builder.Property(x => x.UpdatedAt)
           .HasColumnName("UpdatedAt")
           .HasColumnType("timestamptz")
           .HasConversion(v => v.Value, v => new(v))
           .IsRequired();

        builder.Property(x => x.Active)
           .HasColumnName("Active")
           .HasColumnType("boolean")
           .HasConversion(v => v.Value, v => new(v))
           .IsRequired();
    }
}