using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Classes;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace emperor_mvc.Controllers {
    public class BurialController : Controller {

        [HttpGet]
        public ActionResult Index (BurialModel model, string returnUrl) {
            var filename = "wwwroot/Documents/burial.md";
            model.burialtext = cls_markdown.ConvertMDtoTXT (filename);

            return View (model);
        }
    }
}