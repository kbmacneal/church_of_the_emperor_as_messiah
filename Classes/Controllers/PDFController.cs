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
    public class PDFController : Controller {
        public IActionResult Charity (PDFModel model) {
            model.link = "https://highchurch.space/Documents/ninth_virtue_charity.pdf";
            model.set_html ();
            return View ("Index", model);
        }
        public IActionResult Faith (PDFModel model) {
            model.link = "https://highchurch.space/Documents/faith_and_virtue.pdf";
            model.set_html ();
            return View ("Index", model);
        }
        public IActionResult Teuthem (PDFModel model) {
            model.link = "https://highchurch.space/Documents/Teuthem_Memoriam.pdf";
            model.set_html ();
            return View ("Index", model);
        }
        public IActionResult Debate (PDFModel model) {
            model.link = "https://highchurch.space/Documents/12th_debate_response.pdf";
            model.set_html ();
            return View ("Index", model);
        }
        public IActionResult Excom (PDFModel model) {
            model.link = "https://highchurch.space/Documents/Excommunication.pdf";
            model.set_html ();
            return View ("Index", model);
        }
        public IActionResult Koschei (PDFModel model) {
            model.link = "https://highchurch.space/Documents/koschei_1.pdf";
            model.set_html ();
            return View ("Index", model);
        }
        public IActionResult Berkmann (PDFModel model) {
            model.link = "https://highchurch.space/Documents/berkmann_iii_pr.pdf";
            model.set_html ();
            return View ("Index", model);
        }
        public IActionResult Unity (PDFModel model) {
            model.link = "https://highchurch.space/Documents/spirit_of_unity.pdf";
            model.set_html ();
            return View ("Index", model);
        }
        public IActionResult Questions (PDFModel model) {
            model.link = "https://highchurch.space/Documents/20questions.pdf";
            model.set_html ();
            return View ("Index", model);
        }

        public IActionResult TeuthemCost (PDFModel model) {
            model.link = "https://highchurch.space/Documents/HC_covers_teuthem_cost.pdf";
            model.set_html ();
            return View ("Index", model);
        }

        public IActionResult BerkmannAnnounce (PDFModel model) {
            model.link = "https://highchurch.space/Documents/NeonIII_V2_pamphlet.pdf";
            model.set_html ();
            return View ("Index", model);
        }

        public IActionResult TrillMDP (PDFModel model) {
            model.link = "https://highchurch.space/Documents/Trilliant_MDP.pdf";
            model.set_html ();
            return View ("Index", model);
        }

        public IActionResult Faithfullness (PDFModel model) {
            model.link = "https://highchurch.space/Documents/everyday_faithfullness.pdf";
            model.set_html ();
            return View ("Index", model);
        }

        public IActionResult EridaniExpertise (PDFModel model) {
            model.link = "https://highchurch.space/Documents/eridani_expertise.pdf";
            model.set_html ();
            return View ("Index", model);
        }
        public IActionResult JoinPamphlet (PDFModel model) {
            model.link = "https://highchurch.space/Documents/join_pamphlet.pdf";
            model.set_html ();
            return View ("Index", model);
        }
        public IActionResult Dispensation (PDFModel model) {
            model.link = "https://highchurch.space/Documents/special_dispensation.pdf";
            model.set_html ();
            return View ("Index", model);
        }

        public IActionResult PelaxElevation (PDFModel model) {
            model.link = "https://highchurch.space/Documents/pelax_appointment.pdf";
            model.set_html ();
            return View ("Index", model);
        }

        public IActionResult Treachery (PDFModel model) {
            model.link = "https://highchurch.space/Documents/tiny_extortionists.pdf";
            model.set_html ();
            return View ("Index", model);
        }

        public IActionResult TWeb (PDFModel model) {
            model.link = "https://highchurch.space/Documents/donated_war_artifact.pdf";
            model.set_html ();
            return View ("Index", model);
        }

        public IActionResult DemnophWithdrawn (PDFModel model) {
            model.link = "https://highchurch.space/Documents/demnoph_withdrawn.pdf";
            model.set_html ();
            return View ("Index", model);
        }

        public IActionResult CountessCredits (PDFModel model) {
            model.link = "https://highchurch.space/Documents/countess_and_credits.pdf";
            model.set_html ();
            return View ("Index", model);
        }

        public IActionResult WoeRich (PDFModel model) {
            model.link = "https://highchurch.space/Documents/woe_to_rich_response.pdf";
            model.set_html ();
            return View ("Index", model);
        }

        public IActionResult ChrDeclaration (PDFModel model) {
            model.link = "https://highchurch.space/Documents/chr_announcment.pdf";
            model.set_html ();
            return View ("Index", model);
        }

        public IActionResult RepentantMissive (PDFModel model) {
            model.link = "https://highchurch.space/Documents/repentant_missive.pdf";
            model.set_html ();
            return View ("Index", model);
        }
    }
}