using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using StroudwaterIdentity.EntityFrameworkCore.Seed;

namespace StroudwaterIdentity.EntityFrameworkCore
{
    [DependsOn(
        typeof(StroudwaterIdentityCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class StroudwaterIdentityEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<StroudwaterIdentityDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        StroudwaterIdentityDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        StroudwaterIdentityDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StroudwaterIdentityEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
