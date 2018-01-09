using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using StroudwaterIdentity.Configuration;

namespace StroudwaterIdentity.Web.Host.Startup
{
    [DependsOn(
       typeof(StroudwaterIdentityWebCoreModule))]
    public class StroudwaterIdentityWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public StroudwaterIdentityWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StroudwaterIdentityWebHostModule).GetAssembly());
        }
    }
}
