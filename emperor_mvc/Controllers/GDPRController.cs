using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using emperor_mvc.Models;

namespace emperor_mvc.Controllers
{
    public class GDPRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitForm(GDPRModel model)
        {
            return View();
        }
    }
}