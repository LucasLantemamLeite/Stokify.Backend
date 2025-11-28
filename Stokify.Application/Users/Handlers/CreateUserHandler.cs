using Stokify.Application.Abstractions.Contracts.Mediator;
using Stokify.Application.Result;
using Stokify.Application.Users.Commands;
using Stokify.Application.Users.Contracts.UseCases;
using Stokify.Domain.Users;

namespace Stokify.Application.Users.Handlers;

public sealed class CreateUserHandler : IHandler<CreateUserCommand, Result<User>>
{
    private readonly ICreateUserUseCase _useCase;

    public CreateUserHandler(ICreateUserUseCase useCase)
        => _useCase = useCase;

    public async Task<Result<User>> Handle(CreateUserCommand request)
        => await _useCase.ExecuteAsync(request);

}