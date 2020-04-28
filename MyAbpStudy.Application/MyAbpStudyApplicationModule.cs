using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyAbpStudy.Authorization;

namespace MyAbpStudy
{
    [DependsOn(
        typeof(MyAbpStudyCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyAbpStudyApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyAbpStudyAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyAbpStudyApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
