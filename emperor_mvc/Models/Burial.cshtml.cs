using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using emperor_mvc.Classes;
using System.Web;
using Microsoft.AspNetCore.Hosting;

namespace emperor_mvc.Models
{
    public class BurialModel : PageModel
    {
        public string sermonheader { get; set; }
        public string burialtext { get; set; }

        public void OnGet()
        {
            setContent();
        }

        protected void setContent()
        {
            var filename = "wwwroot/Documents/burial.md";
            
            burialtext = cls_markdown.ConvertMDtoTXT(filename);
            
        }
    }
}