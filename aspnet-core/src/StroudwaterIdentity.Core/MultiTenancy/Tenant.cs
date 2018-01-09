using Abp.MultiTenancy;
using StroudwaterIdentity.Authorization.Users;

namespace StroudwaterIdentity.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
