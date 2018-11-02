using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Classes;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace emperor_mvc.Controllers {
    public class BerkmannController : Controller {

        public IActionResult Index (BerkmannModel model) {
            var filename = "wwwroot/Documents/berkmann_opening.md";
            model.cathedraltext = cls_markdown.ConvertMDtoTXT (filename);

            return View (model);
        }
    }
}