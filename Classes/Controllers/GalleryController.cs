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
    public class GalleryController : Controller {
        public IActionResult Index () {
            return View ();
        }

        public IActionResult Memes (GalleryModel model) {
            List<string> files = System.IO.Directory.GetFiles ("wwwroot/Assets/Memes/").ToList ();

            string prepend = "https://highchurch.space/Assets/Memes/";

            SortedDictionary<string, string> filenames = new SortedDictionary<string, string> ();

            files.ForEach (e => filenames.Add (System.IO.Path.GetFileName (e), String.Concat (prepend, System.IO.Path.GetFileName (e))));

            files = System.IO.Directory.GetFiles ("wwwroot/Assets/Pinups").ToList ();
            prepend = "https://highchurch.space/Assets/Pinups/";

            files.ForEach (e => filenames.Add (System.IO.Path.GetFileName (e), String.Concat (prepend, System.IO.Path.GetFileName (e))));

            List<string> raw_html = new List<string> ();

            KeyValuePair<string, string>[] elements = filenames.ToArray ();

            foreach (KeyValuePair<string, string> element in elements) {
                string add = "<img class=\"photos w-25\" src=\"<element>\" />";
                raw_html.Add (add.Replace ("<element>", element.Value));
                filenames.Remove (element.Key);

        }

        model.row_html = String.Join (System.Environment.NewLine, raw_html);

        return View ("Memes", model);
    }
}
}