namespace Dnms.Core.Entities;

public class Order
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public OrderStatus Status { get; set; } = OrderStatus.Created;
    public decimal Price { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public List<Product> Products { get; set; } = new();
}
