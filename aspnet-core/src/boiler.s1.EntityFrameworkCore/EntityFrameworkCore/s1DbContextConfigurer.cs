using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace boiler.s1.EntityFrameworkCore
{
    public static class s1DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<s1DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<s1DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
