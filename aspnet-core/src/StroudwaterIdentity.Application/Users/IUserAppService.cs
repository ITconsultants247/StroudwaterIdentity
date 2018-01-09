using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using StroudwaterIdentity.Roles.Dto;
using StroudwaterIdentity.Users.Dto;

namespace StroudwaterIdentity.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
