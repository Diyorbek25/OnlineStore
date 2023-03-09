using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Infrastructure.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders");

        builder.HasKey(order => order.Id);

        builder.Property(order => order.TotalPrice)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(order => order.CreatedAt) 
            .IsRequired()
            .HasColumnType("datetime2");

        builder.Property(order => order.UpdatedAt)
            .IsRequired(false)
            .HasColumnType("datetime2");

        builder.HasMany(order => order.OrderItems)
            .WithOne(orderItem => orderItem.Order)
            .HasForeignKey(orderItem => orderItem.OrderId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
