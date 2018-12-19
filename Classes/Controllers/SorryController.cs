using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Classes;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Westwind.Utilities;
using System.IO;

namespace emperor_mvc.Controllers {
    public class SorryController : Controller {

        [HttpGet]
        public ActionResult Index (SorryModel model) {

            var filenames = Directory.GetFiles("wwwroot/Assets/Sorry/").ToList();

            string[] sanitized = new string[filenames.Count()];

            filenames.OrderBy(e=>Int32.Parse(e.Replace(".jpeg","").Replace(".gif","").Replace("wwwroot/Assets/Sorry/",""))).ToList().CopyTo(sanitized);

            model.FileList = sanitized.Select(e=>e.Replace("wwwroot/","")).ToList();

            System.IO.File.WriteAllLines("debug.txt", model.FileList);

            return View (model);
        }
    }
}