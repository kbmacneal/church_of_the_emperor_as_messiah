using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace emperor_mvc.Controllers {
    public class BotController : Controller {
        public class command_help
    {
        public string name {get;set;}
        public string summary {get;set;}
        public bool admin_required {get;set;}
    }
        public IActionResult Index () {

            var path = "commands.json";
            var content = System.IO.File.ReadAllText(path);
            List<command_help> commands = Newtonsoft.Json.JsonConvert.DeserializeObject<List<command_help>>(content);

            ViewBag.commands = commands;

            return View ();
        }
    }
}