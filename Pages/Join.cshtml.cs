using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace church_of_the_emporer_as_messiah.Pages {
    public class JoinModel : PageModel {
        public string Message {
            get;
            set;
        }
        public string Name {
            get;
            set;
        }

        public string Quote {
            get;
            set;
        }
        public void OnGet () {
            Message = "How to Join the Church of the Emperor-as-Messiah";
            Name = "Holy Reference, Sutra 5, Verse 87";
            Quote = "Look at the stars! I cast you among them, to populate them, and bring humanity to the greatest reaches of the universe!";

            //http://www.mariorodriguez.co/2016/03/24/create-a-quote-box-with-html-and-css.html
        }
    }
}