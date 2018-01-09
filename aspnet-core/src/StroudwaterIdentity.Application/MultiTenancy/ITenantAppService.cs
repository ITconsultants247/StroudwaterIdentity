using Abp.Application.Services;
using Abp.Application.Services.Dto;
using StroudwaterIdentity.MultiTenancy.Dto;

namespace StroudwaterIdentity.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
