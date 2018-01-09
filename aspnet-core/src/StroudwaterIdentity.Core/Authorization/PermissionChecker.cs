using Abp.Authorization;
using StroudwaterIdentity.Authorization.Roles;
using StroudwaterIdentity.Authorization.Users;

namespace StroudwaterIdentity.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
