using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Infrastructure.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        builder.HasKey(product => product.Id);

        builder.Property(product => product.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(product => product.Description)
            .HasMaxLength(500);

        builder.Property(product => product.Price)
            .HasColumnType("decimal(18,2)");

        builder.Property(product => product.ImageUrl)
            .HasMaxLength(500);

        builder.HasOne(product => product.Category)
            .WithMany(category => category.Products)
            .HasForeignKey(product => product.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(product => product.ShoppingCartItems)
            .WithOne(shoppingCartItem => shoppingCartItem.Product)
            .HasForeignKey(shoppingCartItem => shoppingCartItem.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(product => product.OrderItems)
            .WithOne(orderItem => orderItem.Product)
            .HasForeignKey(orderItem => orderItem.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

