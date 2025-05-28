using Microsoft.EntityFrameworkCore;
using Projexor.Data.Context;
using Projexor.Data.Repository.Interface;
using Projexor.Data.Repository.Result;
using Projexor.Domain.Entity;

namespace Projexor.Data.Repository;

public class UserAccountRepository(AppDbContext context) : IUserAccountRepository
{
    public async Task<ResultPattern<UserAccount>> CreateAsync(UserAccount user, CancellationToken cancellationToken = default)
    {
        try
        {
            await context.UserAccounts.AddAsync(user, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);

            return ResultPattern<UserAccount>.Ok(user, "Usuário criado com sucesso.");
        }

        catch (Exception e)
        {
            return ResultPattern<UserAccount>.Fail(e.Message);
        }
    }

    public async Task<ResultPattern<UserAccount>> LoginAsync(string login, CancellationToken cancellationToken = default)
    {
        try
        {
            var UserAccount = await context.UserAccounts.FirstOrDefaultAsync(x => x.Login.Value == login, cancellationToken);

            return ResultPattern<UserAccount>.Ok(UserAccount, "Login feito com sucesso.");
        }

        catch (Exception e)
        {
            return ResultPattern<UserAccount>.Fail($"Erro ao realizar login: {e.Message}");
        }
    }

    public async Task<ResultPattern<UserAccount>> DeleteAsync(UserAccount user, CancellationToken cancellationToken = default)
    {
        try
        {
            var userAccount = context.UserAccounts.Remove(user);
            await context.SaveChangesAsync(cancellationToken);

            return ResultPattern<UserAccount>.Ok(userAccount.Entity, "Conta deletada com sucesso.");
        }

        catch (Exception e)
        {
            return ResultPattern<UserAccount>.Fail(e.Message);
        }
    }

    public async Task<ResultPattern<UserAccount>> UpdateAsync(UserAccount user, CancellationToken cancellationToken = default)
    {
        try
        {
            context.UserAccounts.Update(user);
            await context.SaveChangesAsync(cancellationToken);

            return ResultPattern<UserAccount>.Ok(user, "Atualizado com sucesso.");
        }

        catch (Exception e)
        {
            return ResultPattern<UserAccount>.Fail(e.Message);
        }
    }
}