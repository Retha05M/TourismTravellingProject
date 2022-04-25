using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace TourismProject.Web.Views
{
    public abstract class TourismProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TourismProjectRazorPage()
        {
            LocalizationSourceName = TourismProjectConsts.LocalizationSourceName;
        }
    }
}
