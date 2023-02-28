using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Infrastructure.Configurations;

public class ShoppingCartConfiguration : IEntityTypeConfiguration<ShoppingCart>
{
    public void Configure(EntityTypeBuilder<ShoppingCart> builder)
    {
        builder.ToTable("ShoppingCarts");
        builder.HasKey(sc => sc.Id);

        builder.Property(sc => sc.CreatedAt)
            .HasColumnType("datetime2");

        builder.Property(sc => sc.UpdatedAt)
            .HasColumnType("datetime2");

        builder.HasMany(sc => sc.ShoppingCartItems)
            .WithOne(sci => sci.ShoppingCart)
            .HasForeignKey(sci => sci.ShoppingCartId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
