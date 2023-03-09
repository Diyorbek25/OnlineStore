using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Infrastructure.Configurations;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.ToTable("OrderItems");

        builder.HasKey(orderItem => orderItem.Id);

        builder.Property(orderItem => orderItem.Price)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(orderItem => orderItem.Quantity) 
            .IsRequired();
    }
}
