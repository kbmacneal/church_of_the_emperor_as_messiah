using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using emperor_mvc.Classes;


namespace emperor_mvc.Controllers
{


    public class FeedbackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string FeedbackText, string UserName)
        {

            if (ModelState.IsValid)
            {
                feedback feedback = new feedback();
                feedback.FeedbackText = FeedbackText;
                feedback.UserName = UserName;
                Feedback.RegisterResponse(feedback);
                FeedbackModel model = new FeedbackModel();
                return View("Success", model);
            }
            return View("Error");
            
        }

        [HttpGet]
        public ActionResult Success()
        {
            return View();
        }
    }
}