using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using StroudwaterIdentity.Configuration;
using StroudwaterIdentity.Web;

namespace StroudwaterIdentity.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class StroudwaterIdentityDbContextFactory : IDesignTimeDbContextFactory<StroudwaterIdentityDbContext>
    {
        public StroudwaterIdentityDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<StroudwaterIdentityDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            StroudwaterIdentityDbContextConfigurer.Configure(builder, configuration.GetConnectionString(StroudwaterIdentityConsts.ConnectionStringName));

            return new StroudwaterIdentityDbContext(builder.Options);
        }
    }
}
