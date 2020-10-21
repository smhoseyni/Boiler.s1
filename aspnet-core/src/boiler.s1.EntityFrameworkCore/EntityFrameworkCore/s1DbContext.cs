using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using boiler.s1.Authorization.Roles;
using boiler.s1.Authorization.Users;
using boiler.s1.MultiTenancy;

namespace boiler.s1.EntityFrameworkCore
{
    public class s1DbContext : AbpZeroDbContext<Tenant, Role, User, s1DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public s1DbContext(DbContextOptions<s1DbContext> options)
            : base(options)
        {
        }
    }
}
