using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TourismProject.Controllers;

namespace TourismProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TourismProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
