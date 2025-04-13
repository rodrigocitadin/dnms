namespace Dnms.Core.Entities;

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "Unnamed Product";
    public string Description { get; set; } = "Description not provided";
    public decimal Price { get; set; }

    public List<Order> Orders { get; set; } = new();
}
