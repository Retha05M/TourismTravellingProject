using Abp.AspNetCore.Mvc.ViewComponents;

namespace TourismProject.Web.Views
{
    public abstract class TourismProjectViewComponent : AbpViewComponent
    {
        protected TourismProjectViewComponent()
        {
            LocalizationSourceName = TourismProjectConsts.LocalizationSourceName;
        }
    }
}
