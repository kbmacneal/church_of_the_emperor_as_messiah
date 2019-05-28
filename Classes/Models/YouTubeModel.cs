using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace emperor_mvc.Models {
    public class YouTubeModel {
        public string link {
            get;
            set;
        }
        public string embed { get; set; }
        
    }
}