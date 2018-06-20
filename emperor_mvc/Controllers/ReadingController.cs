using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Classes;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace emperor_mvc.Controllers {
    public class ReadingController : Controller {

        [HttpGet]
        public ActionResult Reading (ReadingModel model) {
            var filename = "wwwroot/Documents/Readings/ages.md";
            model.ages_text = cls_markdown.ConvertMDtoTXT (filename);
            filename = "wwwroot/Documents/Readings/qasim.md";
            model.qasim_text = cls_markdown.ConvertMDtoTXT (filename);

            return View (model);
        }
    }
}