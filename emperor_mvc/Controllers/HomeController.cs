using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using emperor_mvc.Models;
using emperor_mvc.Classes;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;
using System.IO;

namespace emperor_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult SignupSuccess()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(string EmailAddress, String Password)
        {

            if (ModelState.IsValid)
            {
                DataManager.insert_user(EmailAddress, Password);

                user usr = DataManager.return_user(EmailAddress).ToList()[0];

                MimeMessage msg = new MimeMessage();

                //From Address    
                string FromAddress = "highchurchofthemessiah@gmail.com";  
                string FromAddressTitle = "The High Church (do not reply)";  
                //To Address    
                string ToAddress = EmailAddress;  
                string ToAddressTitle = EmailAddress;  
                string Subject = "New Account Registration";  

                string text = System.IO.File.ReadAllText("wwwroot/EmailTemplate.md").Replace("<NUMBER>", usr.confirm_number.ToString());

                string htmltext = CommonMark.CommonMarkConverter.Convert(text);

                msg.From.Add(new MailboxAddress(FromAddress,
                                        FromAddress
                                        ));
                msg.To.Add(new MailboxAddress
                                         (ToAddressTitle,
                                         ToAddress
                                         ));
                msg.Subject = Subject; //Subject  
                msg.Body = new TextPart("html")
                {
                    Text = htmltext
                };
            }
            return PartialView("SignupSuccess");
        }
    }
}