using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using emperor_mvc.Models;
using emperor_mvc.Classes;
using System.IO;

namespace emperor_mvc.Controllers
{
    public class PDFController : Controller
    {
        public IActionResult Charity(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/ninth_virtue_charity.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Faith(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/faith_and_virtue.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Teuthem(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/Teuthem_Memoriam.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Debate(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/12th_debate_response.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Excom(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/Excommunication.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Koschei(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/koschei_1.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Berkmann(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/berkmann_iii_pr.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Unity(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/spirit_of_unity.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Questions(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/20questions.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult TeuthemCost(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/HC_covers_teuthem_cost.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult BerkmannAnnounce(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/NeonIII_V2_pamphlet.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult TrillMDP(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/Trilliant_MDP.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult Faithfullness(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/everyday_faithfullness.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult EridaniExpertise(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/eridani_expertise.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult JoinPamphlet(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/join_pamphlet.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Dispensation(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/special_dispensation.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult PelaxElevation(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/pelax_appointment.pdf";
            model.set_html();
            return View("Index", model);
        }
    }
}