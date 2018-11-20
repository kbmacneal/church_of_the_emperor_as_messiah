using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace emperor_mvc.Models {

    public class command_help
    {
        public string name {get;set;}
        public string summary {get;set;}
        public bool admin_required {get;set;}
    }
    public class BotModel {
        public List<command_help> commands{get;set;}
    }
}