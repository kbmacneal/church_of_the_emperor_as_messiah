using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using emperor_mvc.Models;

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
