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
    public class SermonYakiyakModel : PageModel
    {
        public string sermonheader { get; set; }
        public string sermontext { get; set; }
        public string sermonheaderright { get; set; }
        public string sermontextright { get; set; }
        private IHostingEnvironment _env;
        public void HomeController(IHostingEnvironment env)
        {
            _env = env;
        }
        public void OnGet()
        {
            setContent();
        }

        protected void setContent()
        {
            var filename = "wwwroot/Sermons/sermonyakiyah1.md";

            sermonheader = "Preamble";
            sermontext = cls_markdown.ConvertMDtoTXT(filename);

            filename = "wwwroot/Sermons/sermonyakiyah2.md";

            sermonheaderright = "Sermon";

            sermontextright = cls_markdown.ConvertMDtoTXT(filename);
            
        }
    }
}