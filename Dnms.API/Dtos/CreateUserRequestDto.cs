namespace Dnms.API.Dtos;

public class CreateUserRequestDto
{
    public string Name { get; set; } = null!;
    public string Password { get; set; } = null!;
}
