using Microsoft.AspNet.Mvc;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}