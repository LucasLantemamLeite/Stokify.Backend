using Stokify.Application.Abstracts.Markers;

namespace Stokify.Application.Commands.Users;

public sealed record CreateUserCommand(string Name, string Email, string Phone, string Password, sbyte Access) : ICommand;