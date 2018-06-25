using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using emperor_mvc.Models;
using emperor_mvc.Classes;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;
using System.IO;

namespace emperor_mvc.Controllers
{
    public class PDFController : Controller
    {
        public IActionResult Charity(PDFModel model)
        {
            model.link = "~/Documents/ninth_virtue_charity.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Faith(PDFModel model)
        {
            model.link = "~/Documents/faith_and_virtue.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Teuthem(PDFModel model)
        {
            model.link = "~/Documents/Teuthem_Memoriam.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Debate(PDFModel model)
        {
            model.link = "~/Documents/12th_debate_response.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Excom(PDFModel model)
        {
            model.link = "~/Documents/Excommunication.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Koschei(PDFModel model)
        {
            model.link = "~/Documents/koschei_1.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Berkmann(PDFModel model)
        {
            model.link = "~/Documents/berkmann_iii_pr.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Unity(PDFModel model)
        {
            model.link = "~/Documents/spirit_of_unity.pdf";
            model.set_html();
            return View("Index", model);
        }
        public IActionResult Questions(PDFModel model)
        {
            model.link = "~/Documents/20questions.pdf";
            model.set_html();
            return View("Index", model);
        }
    }
}