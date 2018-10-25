using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Classes;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace emperor_mvc.Controllers
{

    public class GDPRController : Controller
    {
        private IHttpContextAccessor _accessor;

        public GDPRController(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string EmailData, string IPData, Boolean CheckboxData)
        {

            if (ModelState.IsValid)
            {

                if(IPData == null)
                {
                    IPData = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                response response = new response();
                response.EmailData = EmailData;
                response.IPData = IPData;
                response.CheckboxData = CheckboxData;

                if (!validate_request(EmailData, IPData, CheckboxData))
                {
                    return View("Problem");
                }
                else
                {
                    GDPR.RegisterResponse(response);
                    return View("Success");
                }
            }
            else
            {
                return View("Problem");
            }

        }

        [HttpGet]
        public ActionResult Success()
        {
            return View();
        }

        private bool validate_request(string email, string ip, Boolean CheckboxData)
        {
            int rtner = 0;
            System.Net.IPAddress addr = System.Net.IPAddress.Parse("1.1.1.1");

            if(email != null)
            {
                if (email.Contains("@")) rtner++;
            }            

            if (System.Net.IPAddress.TryParse(ip, out addr)) rtner++;

            if (CheckboxData) rtner++;

            if (rtner == 3)
            {
                return true;
            }
            else
            { return false; }
        }
    }
}