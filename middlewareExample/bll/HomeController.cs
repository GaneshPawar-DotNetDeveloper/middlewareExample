using Microsoft.AspNetCore.Mvc;

namespace middlewareExample.bll
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
