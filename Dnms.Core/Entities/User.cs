namespace Dnms.Core.Entities;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "Anonymous User";
    public string Password { get; set; } = null!;

    public List<Order> Orders { get; set; } = new();
}
