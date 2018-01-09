using System.Collections.Generic;

namespace StroudwaterIdentity.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
