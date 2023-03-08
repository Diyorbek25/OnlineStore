namespace OnlineStore.Domain.Entities;

public class Order
{
    public int Id { get; }
    public int UserId { get; }
    public User User { get; }
    public DateTime CreatedAt { get; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public decimal TotalPrice { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}
