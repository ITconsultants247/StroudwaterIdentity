using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using StroudwaterIdentity.Authorization.Roles;
using StroudwaterIdentity.Authorization.Users;
using StroudwaterIdentity.MultiTenancy;

namespace StroudwaterIdentity.EntityFrameworkCore
{
    public class StroudwaterIdentityDbContext : AbpZeroDbContext<Tenant, Role, User, StroudwaterIdentityDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public StroudwaterIdentityDbContext(DbContextOptions<StroudwaterIdentityDbContext> options)
            : base(options)
        {
        }
    }
}
