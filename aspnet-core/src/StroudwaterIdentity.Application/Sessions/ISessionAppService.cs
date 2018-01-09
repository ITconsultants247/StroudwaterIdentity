using System.Threading.Tasks;
using Abp.Application.Services;
using StroudwaterIdentity.Sessions.Dto;

namespace StroudwaterIdentity.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
