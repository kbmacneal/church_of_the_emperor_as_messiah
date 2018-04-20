using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace church_of_the_emporer_as_messiah.Pages {
    public class DecreesModel : PageModel {
        public string Message {
            get;
            set;
        }
        public string Decree {
            get;
            set;
        }
        public void OnGet () {
            Message = "Decrees";
            Decree = "A guideline was constructed on how one can be genetically modified and still faithful";
        }
    }
}