using emperor_mvc.Classes;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;

namespace emperor_mvc.Controllers
{
    public class SocialController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<stats> stat_list = new List<stats>();

            using (Npgsql.NpgsqlConnection conn = new NpgsqlConnection(JsonConvert.DeserializeObject<Dictionary<string, string>>(System.IO.File.ReadAllText(@"churchsite.json"))["connection_string"]))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand(@"select * from latestmemcount", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            stat_list.Add(new stats()
                            {
                                name = reader.GetString(1),
                                count = reader.GetInt32(2).ToString()
                            });
                        }
                    }
                }
            }

            ViewBag.stats = stat_list.OrderByDescending(e => Convert.ToInt32(e.count));

            return View();
        }

        public class stats
        {
            public string name { get; set; }
            public string count { get; set; }
        }

        [HttpGet]
        public ActionResult Andophael(SocialModel model)
        {
            var filename = "wwwroot/Documents/andophael.md";
            model.andophael_text = cls_markdown.ConvertMDtoTXT(filename);

            return View(model);
        }
    }
}