using System.Threading.Tasks;
using StroudwaterIdentity.Configuration.Dto;

namespace StroudwaterIdentity.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
