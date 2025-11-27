using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stokify.Domain.Users;

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

        builder.OwnsOne(u => u.Name, name =>
            name.Property(u => u.Value)
                .HasColumnName("Name")
                .HasColumnType("varchar(100)")
                .IsRequired()
        );

        builder.OwnsOne(u => u.Email, email =>
        {
            email.Property(u => u.Value)
                .HasColumnName("Email")
                .HasColumnType("varchar(255)")
                .IsRequired();

            email.HasIndex(u => u.Value, "Unique_Key_Users_Email")
                .IsUnique();
        });

        builder.OwnsOne(u => u.Phone, phone =>
        {
            phone.Property(u => u.Value)
                .HasColumnName("Phone")
                .HasColumnType("varchar(15)")
                .IsRequired();

            phone.HasIndex(u => u.Value, "Unique_Key_Users_Phone")
                .IsUnique();
        });

        builder.OwnsOne(u => u.Password, password =>
            password.Property(u => u.Value)
                .HasColumnName("Password")
                .HasColumnType("varchar(255)")
                .IsRequired()
        );

        builder.OwnsOne(u => u.Access, access =>
            access.Property(u => u.Value)
                .HasColumnName("Access")
                .HasColumnType("smallint")
                .IsRequired()
        );

        builder.OwnsOne(x => x.CreatedAt, created =>
            created.Property(x => x.Value)
                .HasColumnName("CreatedAt")
                .HasColumnType("timestamptz")
                .IsRequired()
        );

        builder.OwnsOne(x => x.UpdatedAt, updated =>
            updated.Property(x => x.Value)
                .HasColumnName("UpdatedAt")
                .HasColumnType("timestamptz")
                .IsRequired()
        );

        builder.OwnsOne(x => x.Active, active =>
            active.Property(x => x.Value)
                .HasColumnName("Active")
                .HasColumnType("boolean")
                .IsRequired()
        );
    }
}