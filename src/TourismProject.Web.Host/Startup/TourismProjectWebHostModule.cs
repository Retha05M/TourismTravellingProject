using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TourismProject.Configuration;

namespace TourismProject.Web.Host.Startup
{
    [DependsOn(
       typeof(TourismProjectWebCoreModule))]
    public class TourismProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TourismProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TourismProjectWebHostModule).GetAssembly());
        }
    }
}
