using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Classes;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace emperor_mvc.Controllers {
    public class AmbigramController : Controller {
        public IActionResult Index () {
            return View ();
        }
        public IActionResult AmbigramSevenSibling () {
            return View ();
        }
    }
}