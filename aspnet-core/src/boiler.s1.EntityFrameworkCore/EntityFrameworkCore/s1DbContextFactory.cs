using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using boiler.s1.Configuration;
using boiler.s1.Web;

namespace boiler.s1.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class s1DbContextFactory : IDesignTimeDbContextFactory<s1DbContext>
    {
        public s1DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<s1DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            s1DbContextConfigurer.Configure(builder, configuration.GetConnectionString(s1Consts.ConnectionStringName));

            return new s1DbContext(builder.Options);
        }
    }
}
