using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boiler.s1.EntityFrameworkCore;
using boiler.s1.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace boiler.s1.Web.Tests
{
    [DependsOn(
        typeof(s1WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class s1WebTestModule : AbpModule
    {
        public s1WebTestModule(s1EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(s1WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(s1WebMvcModule).Assembly);
        }
    }
}