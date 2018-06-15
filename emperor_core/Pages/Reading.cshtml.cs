using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using church_of_the_emporer_as_messiah.Sermons;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace church_of_the_emporer_as_messiah.Pages {
    public class ReadingModel : PageModel {
        public string ages_text {
            get;
            set;
        }
        public string qasim_text {
            get;
            set;
        }
        public void OnGet () {
            setContent ();
        }

        protected void setContent () {
            var filename = "wwwroot/Documents/Readings/ages.md";
            ages_text = cls_markdown.ConvertMDtoTXT (filename);

            filename = "wwwroot/Documents/Readings/qasim.md";
            qasim_text = cls_markdown.ConvertMDtoTXT (filename);

        }
    }
}