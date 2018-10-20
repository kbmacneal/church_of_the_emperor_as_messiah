using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Classes;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace emperor_mvc.Controllers {
    public class SermonController : Controller {

        public ActionResult Index () {
            return View ();
        }

        public ActionResult AudioSermons () {
            return View ("AudioSermons");
        }

        [HttpGet]
        public ActionResult SermonYakiyah (SermonSingleColumnModel model) {
            model.sermonheader = "Preamble";

            var filename = "wwwroot/Documents/Sermons/sermonyakiyah1.md";
            model.sermontext = cls_markdown.ConvertMDtoTXT (filename);

            return View ("SermonSingleColumn", model);
        }

        [HttpGet]
        public ActionResult SermonOne (SermonSingleColumnModel model) {
            model.sermonheader = "The Ten Virtues";

            var filename = "wwwroot/Documents/Sermons/sermonone.md";
            model.sermontext = cls_markdown.ConvertMDtoTXT (filename);

            return View ("SermonSingleColumn", model);
        }

        [HttpGet]
        public ActionResult SermonTwo (SermonSingleColumnModel model) {
            model.sermonheader = "The Interconnected Virtue of Justice";

            var filename = "wwwroot/Documents/Sermons/SermonTwo.md";
            model.sermontext = cls_markdown.ConvertMDtoTXT (filename);

            return View ("SermonSingleColumn", model);
        }

        [HttpGet]
        public ActionResult SermonCabina (SermonSingleColumnModel model) {
            model.sermonheader = "";

            var filename = "wwwroot/Documents/Sermons/sermon_cabina.md";
            model.sermontext = cls_markdown.ConvertMDtoTXT (filename);

            return View ("SermonSingleColumn", model);
        }

        [HttpGet]
        public ActionResult SermonHarvey (SermonSingleColumnModel model) {
            model.sermonheader = "";

            var filename = "wwwroot/Documents/Sermons/sermon_harvey_wedding.md";
            model.sermontext = cls_markdown.ConvertMDtoTXT (filename);
            model.sermonheader = "<div class=\"col-12\"><img class=\"img-fluid mx-auto d-block\" src=\"https://highchurch.space/Assets/harvey_wedding.png\"></img></div>";

            return View ("SermonSingleColumn", model);
        }
    }
}