using Microsoft.AspNetCore.Mvc;

namespace emperor_mvc.Controllers
{
    public class ContentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Blessings()
        {
            return View();
        }

        [HttpGet]
        public ActionResult FromTheDesk()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Join()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Support()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Templates()
        {
            return View();
        }
    }
}