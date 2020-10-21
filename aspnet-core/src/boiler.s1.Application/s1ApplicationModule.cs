﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boiler.s1.Authorization;

namespace boiler.s1
{
    [DependsOn(
        typeof(s1CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class s1ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<s1AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(s1ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
