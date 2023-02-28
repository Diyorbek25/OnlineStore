namespace OnlineStore.Domain.Entities;

public class ShoppingCart
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
}
