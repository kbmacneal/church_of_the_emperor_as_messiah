using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace emperor_mvc.Models {
    public class PDFModel {
        public string link {
            get;
            set;
        }
        public string html{get;set;}
        public void set_html(){
            this.html = @"<a href=\"+ this.link + " class=\"mx-auto d-block\" target=\"_black\">Link to PDF Version</a><iframe class=\"mx-auto d-block\" src=\"/Documents/ninth_virtue_charity.pdf\" width=\"100%\" height=\"100%\"> This browser does not support PDFs. Please download the PDF to view it: <a href=" + this.link + ">Download PDF</a></iframe>";
        }
    }
}