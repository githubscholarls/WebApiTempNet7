using Microsoft.AspNetCore.Mvc;

namespace WT.DirectLogistics.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
