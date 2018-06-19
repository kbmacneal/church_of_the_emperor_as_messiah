using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using emperor_mvc.Classes;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace emperor_mvc.Models {
    public class SocialModel : PageModel {
        public string andophael_text {
            get;
            set;
        }
        public void OnGet () {
            setContent ();
        }

        protected void setContent () {
            var filename = "wwwroot/Documents/andophael.md";
            andophael_text = cls_markdown.ConvertMDtoTXT (filename);

        }
    }
}