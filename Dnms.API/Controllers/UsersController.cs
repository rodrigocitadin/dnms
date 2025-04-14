using Dnms.API.Dtos;
using Dnms.Core.Entities;
using Dnms.Core.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Dnms.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IRepository<User> _repository;

    public UsersController(IRepository<User> repository)
    {
        _repository = repository;
    }

    [HttpPost]
    public async Task<ActionResult<CreateUserResponseDto>> Create([FromBody] CreateUserRequestDto request)
    {
        User user = new();
        user.Name = request.Name;

        PasswordHasher<User> passwordHasher = new();
        user.Password = passwordHasher.HashPassword(user, request.Password);

        var response = new CreateUserResponseDto
        {
            Id = user.Id,
            Name = user.Name
        };

        await _repository.AddAsync(user);
        return Created(string.Empty, response);
    }
}
