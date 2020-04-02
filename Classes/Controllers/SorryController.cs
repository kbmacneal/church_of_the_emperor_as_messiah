using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace emperor_mvc.Controllers
{
    public class SorryController : Controller
    {
        public class file
        {
            public int id { get; set; }
            public string location { get; set; }
        }

        [HttpGet]
        public ActionResult Index(SorryModel model)
        {
            var filenames = Directory.GetFiles("wwwroot/Assets/Sorry/").Where(e => !e.Contains(".mp4") && !e.Contains(".jpg")).ToList();

            string item = "";

            List<file> ordered = new List<file>();

            try
            {
                foreach (var name in filenames)
                {
                    item = name;
                    file f = new file()
                    {
                        location = name,
                        id = Convert.ToInt32(name.Replace(".jpeg", "").Replace(".gif", "").Replace("wwwroot/Assets/Sorry/", ""))
                    };
                    ordered.Add(f);
                }

                model.FileList = ordered.OrderBy(e => e.id).Select(e => e.location).ToList();
            }
            catch (System.Exception)
            {
                Console.WriteLine(item);
                return View(new SorryModel());
            }

            // filenames.OrderBy(e=>Int32.Parse().Where(e=>!e.Contains(".mp4")).ToList().CopyTo(sanitized);

            // model.FileList = sanitized.Select(e=>e.Replace("wwwroot/","")).ToList();

            // System.IO.File.WriteAllLines("debug.txt", model.FileList);

            return View(model);
        }
    }
}