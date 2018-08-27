
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Classes;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace emperor_mvc.Controllers {
    public class DenunciationController : Controller {

        [HttpGet]
        public ActionResult Index () {

            return View ();
        }

        public IActionResult Justice(DenunciationModel model)
        {
            model.link = "https://highchurch.space/Documents/Denunciation/Justice.pdf";
            model.set_html();
            return View("Denunciation", model);
        }
        
        public IActionResult Hope(DenunciationModel model)
        {
            model.link = "https://highchurch.space/Documents/Denunciation/Hope.pdf";
            model.set_html();
            return View("UnderConstruction", model);
        }
        public IActionResult Propriety(DenunciationModel model)
        {
            model.link = "https://highchurch.space/Documents/Denunciation/Propriety.pdf";
            model.set_html();
            return View("Denunciation", model);
        }
        public IActionResult Wisdom(DenunciationModel model)
        {
            model.link = "https://highchurch.space/Documents/Denunciation/Wisdom.pdf";
            model.set_html();
            return View("Denunciation", model);
        }

        public IActionResult Faith(DenunciationModel model)
        {
            model.link = "https://highchurch.space/Documents/Denunciation/Faith.pdf";
            model.set_html();
            return View("Denunciation", model);
        }

        public IActionResult Fortitude(DenunciationModel model)
        {
            model.link = "https://highchurch.space/Documents/Denunciation/Fortitude.pdf";
            model.set_html();
            return View("Denunciation", model);
        }

        public IActionResult Temperance(DenunciationModel model)
        {
            model.link = "https://highchurch.space/Documents/Denunciation/Temperance.pdf";
            model.set_html();
            return View("Denunciation", model);
        }
    }
}