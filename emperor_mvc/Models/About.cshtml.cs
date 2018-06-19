using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace emperor_mvc.Models {
    public class AboutModel : PageModel {
        public string Message {
            get;
            set;
        }
        public string content {
            get;
            set;
        }

        public void OnGet () {
            Message = "THE HIGH COUNCIL AND THE TEN BRANCHES";
            content = "";
        }
    }
}