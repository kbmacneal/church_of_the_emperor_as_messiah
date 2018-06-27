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


    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string question_text, string UserID)
        {

            if (ModelState.IsValid)
            {
                question question = new question();
                question.question_text = question_text;
                question.UserID = UserID;

                Question.RegisterResponse(question);
            }
            return View("Success");
        }

        [HttpGet]
        public ActionResult Success()
        {
            return View();
        }
    }
}