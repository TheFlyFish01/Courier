using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyAbpStudy.Configuration;
using MyAbpStudy.EntityFrameworkCore;
using MyAbpStudy.Migrator.DependencyInjection;

namespace MyAbpStudy.Migrator
{
    [DependsOn(typeof(MyAbpStudyEntityFrameworkModule))]
    public class MyAbpStudyMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MyAbpStudyMigratorModule(MyAbpStudyEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(MyAbpStudyMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                MyAbpStudyConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(MyAbpStudyMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
