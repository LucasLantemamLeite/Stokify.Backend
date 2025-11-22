using Stokify.Application.Commands.Users;
using Stokify.Domain.Entities;

namespace Stokify.Application.Abstracts.Contracts.UseCases.Users;

public interface ICreateUserUseCase : IUseCase<User, CreateUserCommand> { }