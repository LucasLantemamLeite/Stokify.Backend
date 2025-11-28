using Stokify.Application.Abstractions.Contracts.Mediator;
using Stokify.Application.Result;
using Stokify.Domain.Users;

namespace Stokify.Application.Users.Commands;

public sealed record CreateUserCommand(string Name, string Email, string Phone, string Password, int Access) : IRequest<Result<User>>
{
    public required string Name { get; init; } = Name;
    public required string Email { get; init; } = Email;
    public required string Phone { get; init; } = Phone;
    public required string Password { get; init; } = Password;
    public required int Access { get; init; } = Access;
}