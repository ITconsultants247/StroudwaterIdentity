using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using StroudwaterIdentity.Configuration;
using StroudwaterIdentity.EntityFrameworkCore;
using StroudwaterIdentity.Migrator.DependencyInjection;

namespace StroudwaterIdentity.Migrator
{
    [DependsOn(typeof(StroudwaterIdentityEntityFrameworkModule))]
    public class StroudwaterIdentityMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public StroudwaterIdentityMigratorModule(StroudwaterIdentityEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(StroudwaterIdentityMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                StroudwaterIdentityConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StroudwaterIdentityMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
