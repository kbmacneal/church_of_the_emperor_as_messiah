using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace emperor_mvc.Controllers {

    public class response{
        public string EmailData{get;set;}
        public string IPData{get;set;}
        public Boolean CheckboxData{get;set;}

    }
    public class GDPRController : Controller {
        public IActionResult Index () {
            return View ();
        }

        [HttpPost]
        public ActionResult Index(string EmailData, string IPData, Boolean CheckboxData) {

            if (ModelState.IsValid) {
                response response = new response();
                response.EmailData = EmailData;
                response.IPData = IPData;
                response.CheckboxData = CheckboxData;

                string serialized = JsonConvert.SerializeObject(response);

                string name = EmailData.Split('@')[0];


                if(!System.IO.Directory.Exists("wwwroot/GDPR"))
                {
                    System.IO.Directory.CreateDirectory("wwwroot/GDPR");
                }

                System.IO.File.WriteAllText(System.IO.Path.Combine("wwwroot/GDPR",name + ".json"),serialized);

                return RedirectToAction (nameof (Index));
            }
            return View ();
        }
    }
}