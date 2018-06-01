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
    public class SectsModel : PageModel {
        public string koschei_text {
            get;
            set;
        }
        public string nox_text {
            get;
            set;
        }
        public string sol_text {
            get;
            set;
        }
        public void OnGet () {
            setContent ();
        }

        protected void setContent () {
            var filename = "wwwroot/Sects/Koschei.md";
            koschei_text = cls_markdown.ConvertMDtoTXT (filename);

            filename = "wwwroot/Sects/NoxFide.md";
            nox_text = cls_markdown.ConvertMDtoTXT (filename);

            filename = "wwwroot/Sects/SoulExSol.md";
            sol_text = cls_markdown.ConvertMDtoTXT (filename);

        }
    }
}