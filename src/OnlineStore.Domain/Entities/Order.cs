﻿namespace OnlineStore.Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public decimal TotalPrice { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}
