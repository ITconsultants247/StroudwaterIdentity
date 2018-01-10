using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using StroudwaterIdentity.Authorization.Roles;
using StroudwaterIdentity.Authorization.Users;
using StroudwaterIdentity.MultiTenancy;
using Abp.IdentityServer4;

namespace StroudwaterIdentity.EntityFrameworkCore
{
    public class StroudwaterIdentityDbContext : AbpZeroDbContext<Tenant, Role, User, StroudwaterIdentityDbContext>, IAbpPersistedGrantDbContext
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<PersistedGrantEntity> PersistedGrants { get; set; }

        public StroudwaterIdentityDbContext(DbContextOptions<StroudwaterIdentityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigurePersistedGrantEntity();
        }
    }
}
