using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TourismProject.EntityFrameworkCore;
using TourismProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TourismProject.Web.Tests
{
    [DependsOn(
        typeof(TourismProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TourismProjectWebTestModule : AbpModule
    {
        public TourismProjectWebTestModule(TourismProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TourismProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TourismProjectWebMvcModule).Assembly);
        }
    }
}