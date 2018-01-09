using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using StroudwaterIdentity.Configuration.Dto;

namespace StroudwaterIdentity.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : StroudwaterIdentityAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
