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
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Memes(GalleryModel model)
        {
            List<string> files = System.IO.Directory.GetFiles("wwwroot/Assets/Memes/").ToList();

            string prepend = "https://highchurch.space/Assets/Memes/";

            List<string> filenames = new List<string>();

            files.ForEach(e=>filenames.Add(String.Concat(prepend,System.IO.Path.GetFileName(e))));

            List<string> raw_html = new List<string>();

            int i = 0;

            while(filenames.Count > 0)
            {                
                raw_html.Add("<div class=\"row row-fluid mb-4\">");

                int count = filenames.Count() >= 3 ? 3 : filenames.Count();

                string[] elements = filenames.Take(count).ToArray();

                foreach(string element in elements)
                {
                    string add = "<div class=\"col-md-4\"><div class=\"card\"><img class=\"img-scaled\" src=\"<element>\"></div></div>";
                    raw_html.Add(add.Replace("<element>",element));
                }

                raw_html.Add("</div>");

                filenames.RemoveRange(0,3);
            }

            model.row_html = String.Join(System.Environment.NewLine,raw_html);

            return View("Memes",model);
        }
    }
}