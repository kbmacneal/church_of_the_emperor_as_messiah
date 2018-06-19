using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using emperor_mvc.Classes;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace emperor_mvc.Models
{
    public class GDPRModel : PageModel
    {
        public string EmailData{get;set;}
        public string IPData {get;set;}
        public Boolean CheckboxData {get;set;}
        public void OnGet()
        {
            
        }
        
    }
}