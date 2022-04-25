using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TourismProject.Authorization;

namespace TourismProject
{
    [DependsOn(
        typeof(TourismProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TourismProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TourismProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TourismProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
