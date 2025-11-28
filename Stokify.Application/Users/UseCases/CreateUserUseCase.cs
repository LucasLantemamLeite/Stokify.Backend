using Stokify.Application.Result;
using Stokify.Application.Shared.Contracts.WorkUnit;
using Stokify.Application.Users.Commands;
using Stokify.Application.Users.Contracts.Repositories;
using Stokify.Application.Users.Contracts.UseCases;
using Stokify.Domain.Users;

namespace Stokify.Application.Users.UseCases;

public sealed class CreateUserUseCase : ICreateUserUseCase
{
    private readonly IUserRepository _userRepository;
    private readonly IWorkOfUnit _workOfUnit;
    public CreateUserUseCase(IUserRepository userRepository, IWorkOfUnit workOfUnit)
    {
        _userRepository = userRepository;
        _workOfUnit = workOfUnit;
    }

    public async Task<Result<User>> ExecuteAsync(CreateUserCommand request)
    {
        try
        {
            if (await _userRepository.EmailInUseAsync(request.Email))
                return Result<User>.Fail("");

            if (await _userRepository.PhoneInUseAsync(request.Phone))
                return Result<User>.Fail("");

            var user = new User
            (
                name: request.Name,
                email: request.Email,
                phone: request.Phone,
                password: request.Password,
                access: request.Access
            );

            if (!user.Validate())
                return Result<User>.Fail("Usuário: erro ao criar conta.", user);

            await _userRepository.CreateAsync(user);

            await _workOfUnit.CommitAsync();

            return Result<User>.Ok("Conta criada com sucesso", user);
        }

        catch
        {
            return Result<User>.Fail("Falha interna no servidor.");
        }
    }
}