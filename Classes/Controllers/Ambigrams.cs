using Microsoft.AspNetCore.Mvc;

namespace emperor_mvc.Controllers
{
    public class AmbigramController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AmbigramSevenSibling()
        {
            return View();
        }
    }
}