using Microsoft.AspNetCore.Mvc;

namespace emperor_mvc.Controllers
{
    public class TemplatesController : Controller
    {
        public IActionResult Templates()
        {
            return View();
        }
    }
}