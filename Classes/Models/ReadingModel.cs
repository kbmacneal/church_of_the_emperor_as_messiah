using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace emperor_mvc.Models {
    public class ReadingModel {
        public string ages_text {
            get;
            set;
        }
        public string qasim_text {
            get;
            set;
        }
        public string creation_text {
            get;
            set;
        }
    }
}