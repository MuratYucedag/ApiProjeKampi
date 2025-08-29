using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
