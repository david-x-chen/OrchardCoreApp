using Microsoft.AspNetCore.Mvc;

namespace OrchardCoreApp.TestModule.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
