using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Classes;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace emperor_mvc.Controllers {
    public class FAQController : Controller {

        [HttpGet]
        public ActionResult Index (FAQModel model) {
            var filename = "wwwroot/Documents/FAQ.md";
            model.FAQtext = cls_markdown.ConvertMDtoTXT (filename);

            return View (model);
        }
    }
}