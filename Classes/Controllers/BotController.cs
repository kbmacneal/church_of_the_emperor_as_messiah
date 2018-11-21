using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using MoreLinq;

namespace emperor_mvc.Controllers {
    public class BotController : Controller {
        public class command_help
    {
        public string name {get;set;}
        public string summary {get;set;}
        public bool admin_required {get;set;}
    }
        public IActionResult Index () {
            List<command_help> commands = new List<command_help>();

            var path = "commands.json";
            string content = "";
            
            if(!System.IO.File.Exists(path))
            {
                commands.Add(new command_help{name="Update commands",summary="",admin_required=false});

                ViewBag.commands = commands;

                return View ();
            }
            else
            {
                content = System.IO.File.ReadAllText(path);
            }

            if(content == "")
            {
                commands.Add(new command_help{name="Update commands",summary="",admin_required=false});

                ViewBag.commands = commands;

                return View ();
            }
            else
            {
                commands= Newtonsoft.Json.JsonConvert.DeserializeObject<List<command_help>>(content).DistinctBy(e=>e.name).OrderBy(e=>e.name).ToList();
            }            

            ViewBag.commands = commands;

            return View ();
        }
    }
}