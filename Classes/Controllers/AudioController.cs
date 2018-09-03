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
    public class AudioController : Controller {
        public IActionResult Index (AudioModel model) {
            model.path = "https://highchurch.space/Assets/Audio/test.mp3";
            model.set_html ();
            return View ("Index", model);
        }

        public IActionResult Meeting (AudioModel model) {
            model.path = "https://highchurch.space/Assets/Audio/Meeting.mp3";
            model.set_html ();
            return View ("Index", model);
        }
        public IActionResult MeetingTwo (AudioModel model) {
            model.path = "https://highchurch.space/Assets/Audio/Meeting2.mp3";
            model.set_html ();
            return View ("Index", model);
        }
    }
}