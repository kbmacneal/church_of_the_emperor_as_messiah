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
    public class SermonTwo : PageModel
    {
        public string sermonheader { get; set; }
        public string sermontext { get; set; }

        public void OnGet()
        {
            setContent();
        }

        protected void setContent()
        {
            var filename = "wwwroot/Sermons/SermonTwo.md";

            sermonheader = "";
            sermontext = cls_markdown.ConvertMDtoTXT(filename);
            
        }
    }
}