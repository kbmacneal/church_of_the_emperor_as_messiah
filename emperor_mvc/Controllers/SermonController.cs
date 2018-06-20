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

            var filename = "wwwroot/Sermons/sermonyakiyah1.md";
            model.sermontext = cls_markdown.ConvertMDtoTXT (filename);

            filename = "wwwroot/Sermons/sermonyakiyah2.md";
            model.sermontextright = cls_markdown.ConvertMDtoTXT (filename);

            return View (model);
        }

        [HttpGet]
        public ActionResult SermonOne (SermonOneModel model) {
            model.sermonheader="The Ten Virtues";

            var filename = "wwwroot/Sermons/sermonone.md";
            model.sermontext = cls_markdown.ConvertMDtoTXT (filename);

            return View (model);
        }

        [HttpGet]
        public ActionResult SermonTwo (SermonTwoModel model) {
            model.sermonheader="The Interconnected Virtue of Justice";

            var filename = "wwwroot/Sermons/SermonTwo.md";
            model.sermontext = cls_markdown.ConvertMDtoTXT (filename);

            return View (model);
        }
    }
}