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
        public string title {
            get;
            set;
        }
        public string content {
            get;
            set;
        }
        public void OnGet () {
            Message = "How to Join the Church of the Emperor-as-Messiah";
            Name = "Holy Reference, Sutra 5, Verse 87";
            Quote = "Look at the stars! I cast you among them, to populate them, and bring humanity to the greatest reaches of the universe!";
            title = "Join The Ranks Of The Faithful";
            content = "The High Church always welcomes Children of the Empire to its ranks. Live a faithful life in service of God and the Messiah. Dental plans may or may not be included - ask your local Priest if they apply to you. If you are somewhere without a local Priest, do not despair, and contact the Church via Discord or Twitter.";
            //http://www.mariorodriguez.co/2016/03/24/create-a-quote-box-with-html-and-css.html
        }
    }
}