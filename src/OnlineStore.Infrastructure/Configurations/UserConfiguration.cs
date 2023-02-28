using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");
        builder.HasKey(user => user.Id);

        builder.Property(user => user.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(user => user.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(user => user.Password)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(user => user.Phone)
            .HasMaxLength(20);

        builder.Property(user => user.Address)
            .HasMaxLength(200);

        builder.HasMany(user => user.ShoppingCarts)
            .WithOne(shoppingCart => shoppingCart.User)
            .HasForeignKey(shoppingCart => shoppingCart.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.Orders)
            .WithOne(order => order.User)
            .HasForeignKey(order => order.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

