using System.Threading.Tasks;
using Abp.Application.Services;
using StroudwaterIdentity.Authorization.Accounts.Dto;

namespace StroudwaterIdentity.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
