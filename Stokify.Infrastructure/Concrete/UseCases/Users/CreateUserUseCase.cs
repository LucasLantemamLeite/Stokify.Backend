using Stokify.Application.Abstracts.Contracts.Queries;
using Stokify.Application.Abstracts.Contracts.Repositories;
using Stokify.Application.Abstracts.Contracts.UseCases.Users;
using Stokify.Application.Abstracts.Contracts.WorkUnit;
using Stokify.Application.Commands.Users;
using Stokify.Application.Results;
using Stokify.Domain.Entities;

namespace Stokify.Infrastructure.Concrete.UseCases.Users;

public sealed class CreateUserUseCase(IUserRepository userRepository, IUserQuery userQuery, IWorkOfUnit workOfUnit) : ICreateUserUseCase
{
    public async Task<Result<User>> ExecuteAsync(CreateUserCommand command)
    {
        try
        {
            if (await userQuery.EmailInUseAsync(command.Email))
                return Result<User>.Fail("Email já está em uso.");

            if (await userQuery.PhoneInUseAsync(command.Phone))
                return Result<User>.Fail("Número de telefone já está em uso.");

            var user = new User(
                name: command.Name,
                email: command.Email,
                phone: command.Phone,
                password: command.Password,
                access: command.Access
            );

            if (!user.Validate())
                return Result<User>.Fail($"{user.Notifications}");

            await userRepository.CreateAsync(user);

            var rows = await workOfUnit.CommitAsync();

            if (rows < 1)
                return Result<User>.Fail("");

            return Result<User>.Ok("Conta criada com sucesso.");
        }

        catch
        {
            return Result<User>.Fail("Falha interna do servidor. Tente novamente mais tarde.");
        }
    }
}