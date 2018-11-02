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
    public class HomeController : Controller {
        private Dictionary<int, string> Virtues = new Dictionary<int, string> () { { 0, "<strong>Hope</strong> - \"We must never despair, no matter how dark the hour, as God shines their light upon us.\" Hope is exemplified by the conquest of despair, symbolized most prominently by the restriction of mourning to a designated period, as well as the teaching of the Virtues to the ignorant." }, { 1, "<strong>Faith</strong> - \"Faith above all. We must trust God and their chosen Emperox to guide us.” Faith is exemplified by daily prayer, regular attendance of Church ceremonies, dutiful tithing, and pilgrimage to holy sites." }, { 2, "<strong>Propriety</strong> - \"We must be obedient to tradition, ceremony, courtesy and station.\" Propriety is exemplified by respectful loyalty to righteous authority and cultural norms, along with unfailing intolerance for all heretics and heathens. Custom, dress, and technology all must adhere to Propriety." }, { 3, "<strong>Justice</strong> - \"We must reward those who behave rightly and punish those who do not.\" Justice is exemplified by its unflinching enforcement, and we must correct our own failings before looking to those of others." }, { 4, "<strong>Fortitude</strong> - \"We must patiently endure the challenges laid upon us and follow the rightful path despite them.\" Fortitude is exemplified by steadfast courage and endurance in the face of adversity, particularly in avoiding all cringing or complaint when upon holy ground or fulfilling holy duties." }, { 5, "<strong>Wisdom</strong> - \"We must strive to see the world in its truth and shape it according to God’s will.\" Wisdom is exemplified by perceived the flawed world as it is, but never losing sight of what it should be.  Daily reflection upon the sacred texts and their application to our lives is essential to Wisdom." }, { 6, "<strong>Temperance</strong> - \"We must show prudent moderation and diligent control over our desires.\" Temperance is exemplified by self-restraint in all facets, particularly regular fasting and avoidance of intoxicants." }, { 7, "<strong>Diligence</strong> - \"We must be ever persistent and expend all effort and attention in keeping ourselves and others to the true path.\" Diligence is exemplified by constant, tireless vigilance against temptation and treachery in all aspects of life." }, { 8, "<strong>Charity</strong> - \"We must show compassion to those worthy of God’s mercy.\" Charity is exemplified by philanthropic acts and outreach to faithful sufferers." }, { 9, "<strong>Integrity</strong> - \"We must honor our oaths and uphold the truth.\" Integrity is exemplified by unfailing honesty and the exposure of deviants, as well as regular confession of our failings." }
        };
        public IActionResult Index (HomeModel model) {
            model.VirtueText = Virtues[DateTime.Now.Day % 10];
            return View (model);
        }

        public IActionResult Cactus () {
            return View ();
        }

        public IActionResult Privacy () {
            return View ();
        }
    }
}