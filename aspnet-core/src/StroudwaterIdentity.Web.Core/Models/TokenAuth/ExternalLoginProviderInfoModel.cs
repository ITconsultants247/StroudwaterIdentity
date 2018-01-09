using Abp.AutoMapper;
using StroudwaterIdentity.Authentication.External;

namespace StroudwaterIdentity.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
