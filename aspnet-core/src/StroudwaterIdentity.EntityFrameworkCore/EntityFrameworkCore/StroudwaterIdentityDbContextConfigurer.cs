using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace StroudwaterIdentity.EntityFrameworkCore
{
    public static class StroudwaterIdentityDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<StroudwaterIdentityDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<StroudwaterIdentityDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
