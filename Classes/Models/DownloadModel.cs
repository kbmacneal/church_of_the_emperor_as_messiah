using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace emperor_mvc.Models {
    public class DownloadModel {
        public string path { get; set; }

        public string html { get; set; }

        public string link_html { get; set; }

        public void set_html () {
            this.link_html = "<a class=\"mx-auto d-block\" href=\"" + this.path + "\" target=\"_blank\">Link to Audio File</a>";
        }
    }
}