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
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace church_of_the_emporer_as_messiah.Pages
{
    public class GDPRModel : PageModel
    {
        public string EmailData{get;set;}
        public string IPData {get;set;}
        public Boolean CheckboxData {get;set;}

        public class submission
        {
            public string email {get;set;}
            public string IP {get;set;}
            public Boolean accepted {get;set;}
        }

        public void OnGet()
        {
            
        }
        
        public void OnPost()
        {
            submission sub = new submission();

            sub.email = EmailData;
            sub.IP = IPData;
            sub.accepted = CheckboxData;


        }
        
    }
}