using Stokify.Application.Shared.Contracts;
using Stokify.Application.Shared.Results;
using Stokify.Application.Users.Contracts.Repositories;
using Stokify.Application.Users.Contracts.UseCases;
using Stokify.Application.Users.Requests;
using Stokify.Domain.Users;

namespace Stokify.Application.Users.UseCases;

public sealed class CreateUserUseCase(IUserRepository userRepository, IUnitOfWork unitOfWork) : ICreateUserUseCase
{
    public async Task<Result<User>> ExecuteAsync(CreateUserRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            if (await userRepository.EmailInUseAsync(request.Email))
                return Result<User>.Fail("Email já está em uso.");

            if (await userRepository.PhoneInUseAsync(request.Phone))
                return Result<User>.Fail("Número de telefone já está em uso.");

            var user = new User(
                name: request.Name,
                email: request.Email,
                phone: request.Phone,
                password: request.Password,
                role: 1
            );

            userRepository.Create(user);

            var rows = await unitOfWork.CommitAsync(cancellationToken);

            if (rows != 1)
                return Result<User>.Fail("Falha ao criar conta do usuário.");

            return Result<User>.Success("Conta criada com sucesso.", user);
        }

        catch (OperationCanceledException)
        {
            return Result<User>.Fail("Operação cancelada pelo cliente.");
        }

        catch
        {
            return Result<User>.Fail("Erro interno no servidor. Tente novamente mais tarde.");
        }
    }
}