using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace StroudwaterIdentity.Controllers
{
    public abstract class StroudwaterIdentityControllerBase: AbpController
    {
        protected StroudwaterIdentityControllerBase()
        {
            LocalizationSourceName = StroudwaterIdentityConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
