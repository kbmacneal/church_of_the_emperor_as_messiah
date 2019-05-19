using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Classes;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Treachery(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/tiny_extortionists.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult TWeb(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/donated_war_artifact.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult DemnophWithdrawn(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/demnoph_withdrawn.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult CountessCredits(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/countess_and_credits.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult WoeRich(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/woe_to_rich_response.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult ChrDeclaration(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/chr_announcment.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult RepentantMissive(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/repentant_missive.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult NewVoice(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/new_grand_voice.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult FaithfulSeeker(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/faithful_seeker.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult LongLiveEmpire(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/long_live_empire.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult ChildrenDemnoph(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/children_of_demnoph.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult MercifulGod(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/merciful_god.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult FifthTale(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/The_Tale_of_the_Fifth.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult FinalSunset(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/the_final_sunset.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult MoralAndAlien(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/moral_and_alien_mind.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult TextTour(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/end_day_text_tour.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult ACREAcceptance(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/acre_surrender_accept.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult ACREPR(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/acre_surrender_pr.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult PRISMSurrender(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/prism_surrender_acceptance.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult VirtueWeeds(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/WeedsOnThePathOfVirtue.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult VirtuousAction(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/VirtuousAction.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult HandBird(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/ABirdInTheHand.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult RememberGats(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/remember_gats.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult Miansha(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/miansha.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult EridanusResponse(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/To_Our_Children.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult TooManyBarons(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/TooManyBarons.pdf";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult MoreMeetings(PDFModel model)
        {
            model.link = "https://highchurch.space/Documents/MoreMeetings.pdf";
            model.set_html();
            return View("Index", model);
        }
    }
}