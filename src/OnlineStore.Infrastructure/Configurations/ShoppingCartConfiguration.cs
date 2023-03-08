using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Infrastructure.Configurations;

public class ShoppingCartConfiguration : IEntityTypeConfiguration<ShoppingCart>
{
    public void Configure(EntityTypeBuilder<ShoppingCart> builder)
    {
        builder.ToTable("ShoppingCarts");
        builder.HasKey(shoppingCart => shoppingCart.Id);

        builder.Property(shoppingCart => shoppingCart.CreatedAt)
            .HasColumnType("datetime2");

        builder.Property(shoppingCart => shoppingCart.UpdatedAt)
            .HasColumnType("datetime2");

        builder.HasMany(shoppingCart => shoppingCart.ShoppingCartItems)
            .WithOne(shoppingCartItem => shoppingCartItem.ShoppingCart)
            .HasForeignKey(shoppingCartItem => shoppingCartItem.ShoppingCartId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
