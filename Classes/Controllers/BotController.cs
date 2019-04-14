using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using MoreLinq;
using Newtonsoft.Json;
using Npgsql;

namespace emperor_mvc.Controllers
{
    public class BotController : Controller
    {
        public class command_help
        {
            public int id { get; set; }
            public string name { get; set; }
            public string summary { get; set; }
            public bool admin_required { get; set; }
        }

        public IActionResult Index()
        {
            List<command_help> commands = new List<command_help>();

            using (Npgsql.NpgsqlConnection conn = new NpgsqlConnection(JsonConvert.DeserializeObject<Dictionary<string, string>>(System.IO.File.ReadAllText(@"churchsite.json"))["connection_string"]))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand(@"select * from commands", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            commands.Add(new command_help()
                            {
                                id = reader.GetInt32(0),
                                name = reader.GetString(1),
                                summary = reader.GetString(2),
                                admin_required = reader.GetBoolean(3)
                            });
                        }
                    }
                }
            }

            ViewBag.commands = commands;

            return View();
        }
    }
}