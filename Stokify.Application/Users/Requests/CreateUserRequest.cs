namespace Stokify.Application.Users.Requests;

public sealed record CreateUserRequest(string Name, string Email, string Phone, string Password);