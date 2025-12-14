using Stokify.Application.Shared.Contracts;
using Stokify.Application.Shared.Results;
using Stokify.Application.Users.Requests;
using Stokify.Domain.Users;

namespace Stokify.Application.Users.Contracts.UseCases;

public interface ICreateUserUseCase : IUseCase<CreateUserRequest, Result<User>>;