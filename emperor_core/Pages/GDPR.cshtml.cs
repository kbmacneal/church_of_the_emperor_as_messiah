using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using church_of_the_emporer_as_messiah.Sermons;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System.IO;
using Microsoft.Extensions.FileProviders;

namespace church_of_the_emporer_as_messiah.Pages
{
    public class GDPRModel : PageModel
    {
        public string TextBoxStringData { get; set; }

        public string TextBoxIPData { get; set; }

        public bool CheckboxData { get; set; }

        public string AlertHTML {get; set;}

        public class contact
        {
            public string email {get;set;}
            public string IP {get;set;}
            public Boolean acceptance {get;set;}
        }

        public void OnGet()
        {
            AlertHTML = "";
        }

        [HttpPost]
        public ActionResult Create(contact contact)
        {
            if(CheckboxData)
            {
                contact.email = TextBoxStringData;
                contact.IP = TextBoxIPData;
                contact.acceptance = CheckboxData;
                AlertHTML = "";

                string serialized = JsonConvert.SerializeObject(contact);

                System.IO.File.WriteAllText(System.IO.Path.Combine("wwwroot/GDPR", contact.email),serialized);

                AlertHTML = "<div class=\"alert alert-success\">You have successfully submitted your request. Please allow five business days for the completion of your request</div>";
            }
            else{
                AlertHTML = "<div id=\"dv_alert\" class=\"alert alert-warning\"><h4 class=\"alert-heading\">Warning!</h4><p class=\"mb-0\">You must acknowledge your age and acceptance before continuing</p></div>";                
            }
            return Redirect("");
        }
    }
}