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

        public ActionResult Index(){
            return View();
        }

        [HttpGet]
        public ActionResult SermonYakiyah (SermonYakiyahModel model) {
            model.sermonheader="Preamble";
            model.sermonheaderright="Sermon";

            var filename = "wwwroot/Documents/Sermons/sermonyakiyah1.md";
            model.sermontext = cls_markdown.ConvertMDtoTXT (filename);

            filename = "wwwroot/Documents/Sermons/sermonyakiyah2.md";
            model.sermontextright = cls_markdown.ConvertMDtoTXT (filename);

            return View (model);
        }

        [HttpGet]
        public ActionResult SermonOne (SermonOneModel model) {
            model.sermonheader="The Ten Virtues";

            var filename = "wwwroot/Documents/Sermons/sermonone.md";
            model.sermontext = cls_markdown.ConvertMDtoTXT (filename);

            return View (model);
        }

        [HttpGet]
        public ActionResult SermonTwo (SermonTwoModel model) {
            model.sermonheader="The Interconnected Virtue of Justice";

            var filename = "wwwroot/Documents/Sermons/SermonTwo.md";
            model.sermontext = cls_markdown.ConvertMDtoTXT (filename);

            return View (model);
        }

        [HttpGet]
        public ActionResult SermonCabina (SermonTwoModel model) {
            model.sermonheader="";

            var filename = "wwwroot/Documents/Sermons/sermon_cabina.md";
            model.sermontext = cls_markdown.ConvertMDtoTXT (filename);

            return View (model);
        }

        [HttpGet]
        public ActionResult SermonHarvey (SermonTwoModel model) {
            model.sermonheader="";

            var filename = "wwwroot/Documents/Sermons/sermon_harvey_wedding.md";
            model.sermontext = cls_markdown.ConvertMDtoTXT (filename);
            model.sermonheader="From the wedding of Harvey, Director of ACRE";

            return View (model);
        }
    }
}