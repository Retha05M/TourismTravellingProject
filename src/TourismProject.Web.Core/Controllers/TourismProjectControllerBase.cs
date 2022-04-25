using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TourismProject.Controllers
{
    public abstract class TourismProjectControllerBase: AbpController
    {
        protected TourismProjectControllerBase()
        {
            LocalizationSourceName = TourismProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
