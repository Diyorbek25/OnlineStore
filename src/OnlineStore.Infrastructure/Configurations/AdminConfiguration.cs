using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Infrastructure.Configurations;

public class AdminConfiguration : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> builder)
    {
        builder.ToTable("Admins");

        builder.HasKey(admin => admin.Id);

        builder.Property(admin => admin.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(admin => admin.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(admin => admin.Password)
            .IsRequired()
            .HasMaxLength(100);
    }
}
