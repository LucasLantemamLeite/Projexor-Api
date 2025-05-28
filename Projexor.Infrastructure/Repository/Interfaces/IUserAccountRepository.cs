using Projexor.Data.Repository.Result;
using Projexor.Domain.Entity;

namespace Projexor.Data.Repository.Interface;

public interface IUserAccountRepository
{
    Task<ResultPattern<UserAccount>> CreateAsync(UserAccount user, CancellationToken cancellationToken = default);
    Task<ResultPattern<UserAccount>> LoginAsync(string login, CancellationToken cancellationToken = default);
    Task<ResultPattern<UserAccount>> DeleteAsync(UserAccount user, CancellationToken cancellationToken = default);
    Task<ResultPattern<UserAccount>> UpdateAsync(UserAccount user, CancellationToken cancellationToken = default);
}