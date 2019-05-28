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
    public class YouTubeController : Controller
    {
        public IActionResult Revelation(YouTubeModel model)
        {
            model.link = "https://youtu.be/P5m567jUWrA";
            model.embed = "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/P5m567jUWrA\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>";
            return View("Index", model);
        }
    }
}