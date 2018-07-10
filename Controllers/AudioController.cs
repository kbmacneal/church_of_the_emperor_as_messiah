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
    public class AudioController : Controller
    {
        public IActionResult Meeting(AudioModel model)
        {
            model.path = "Assets/Audio/test.mp3";
            model.set_html();
            return View("Index", model);
        }
    }
}