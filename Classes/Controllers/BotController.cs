using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace emperor_mvc.Controllers {
    public class BotController : Controller {
        public IActionResult Index (BotModel model) {

            // model.commands = Newtonsoft.Json.JsonConvert.DeserializeObject<List<emperor_mvc.Models.command_help>>(System.IO.File.ReadAllText("commands.json"));

            return View (Newtonsoft.Json.JsonConvert.DeserializeObject<List<emperor_mvc.Models.command_help>>(System.IO.File.ReadAllText("commands.json")));
        }
    }
}