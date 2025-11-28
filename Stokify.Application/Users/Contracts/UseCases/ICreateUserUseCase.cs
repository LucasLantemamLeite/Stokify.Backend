using Stokify.Application.Result;
using Stokify.Application.Shared.Contracts.UseCases;
using Stokify.Application.Users.Commands;
using Stokify.Domain.Users;

namespace Stokify.Application.Users.Contracts.UseCases;

public interface ICreateUserUseCase : IUseCase<CreateUserCommand, Result<User>>;