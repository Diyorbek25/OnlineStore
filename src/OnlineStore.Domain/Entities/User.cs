namespace OnlineStore.Domain.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Salt { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public ICollection<Role> Roles { get; set; }
    public ICollection<ShoppingCart> ShoppingCarts { get; set; }
    public ICollection<Order> Orders { get; set; }
}
