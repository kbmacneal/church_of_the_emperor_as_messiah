using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using emperor_mvc.Classes;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace church_of_the_emporer_as_messiah.Pages {
    public class DecreesModel : PageModel {
        public string synth_decree_text {
            get;
            set;
        }

        public string mod_text{
            get;
            set;
        }
        public void OnGet () {
            setContent ();
        }

        protected void setContent () {
            var filename = "wwwroot/Documents/Decrees/Synthetic_Decree.md";
            synth_decree_text = cls_markdown.ConvertMDtoTXT (filename);

            filename = "wwwroot/Documents/Decrees/genetic_modification.md";
            mod_text=cls_markdown.ConvertMDtoTXT(filename);

        }
    }
}