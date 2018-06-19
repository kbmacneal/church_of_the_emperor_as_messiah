using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using church_of_the_emporer_as_messiah.Pages;
using church_of_the_emporer_as_messiah.Sermons;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;

namespace church_of_the_emporer_as_messiah.Controllers {
    public class submission {
        public string email { get; set; }
        public string IP { get; set; }
        public Boolean accepted { get; set; }
    }
    public class GDPRController : Controller {
        [HttpGet]
        public IActionResult Index () {
            return View ();
        }

        [HttpPost]
        public ActionResult Index (GDPRModel model) {
            submission sub = new submission ();

            sub.email = model.EmailData;
            sub.IP = model.IPData;
            sub.accepted = model.CheckboxData;

            string serialized = JsonConvert.SerializeObject (sub);

            System.IO.File.WriteAllText (System.IO.Path.Combine ("wwwroot/GDPR", sub.email), serialized);

            return View ();

        }
    }
}