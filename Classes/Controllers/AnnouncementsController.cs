using Microsoft.AspNetCore.Mvc;

namespace emperor_mvc.Controllers
{
    public class AnnouncementsController : Controller
    {
        [HttpGet]
        public IActionResult Charity()
        {
            return View();
        }
    }
}