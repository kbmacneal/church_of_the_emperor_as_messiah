using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace church_of_the_emporer_as_messiah.Pages {
    public class TenBlessings : PageModel {
        public string Message {
            get;
            set;
        }
        public void OnGet () {
            Message = "The 10 Blessings of our Faith";
        }
    }
}