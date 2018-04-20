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
        public string blessing_1 {
            get;
            set;
        }
        public string blessing_2 {
            get;
            set;
        }
        public string blessing_3 {
            get;
            set;
        }
        public string blessing_4 {
            get;
            set;
        }
        public string blessing_5 {
            get;
            set;
        }
        public string blessing_6 {
            get;
            set;
        }
        public string blessing_7 {
            get;
            set;
        }
        public string blessing_8 {
            get;
            set;
        }
        public string blessing_9 {
            get;
            set;
        }
        public string blessing_10 {
            get;
            set;
        }
        public void OnGet () {
            Message = "The 10 Blessings of our Faith";

        }
    }
}