using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using StroudwaterIdentity.Authorization;

namespace StroudwaterIdentity
{
    [DependsOn(
        typeof(StroudwaterIdentityCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class StroudwaterIdentityApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<StroudwaterIdentityAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(StroudwaterIdentityApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
