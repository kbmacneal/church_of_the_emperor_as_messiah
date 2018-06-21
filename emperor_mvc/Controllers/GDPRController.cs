using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using emperor_mvc.Classes;


namespace emperor_mvc.Controllers {

    
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

                GDPR.RegisterResponse(response);

                return RedirectToAction (nameof (Index));
            }
            return View ();
        }
    }
}