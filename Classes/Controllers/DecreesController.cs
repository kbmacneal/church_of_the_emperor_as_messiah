using emperor_mvc.Classes;
using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace emperor_mvc.Controllers
{
    public class DecreesController : Controller
    {
        [HttpGet]
        public ActionResult Index(DecreesModel model)
        {
            var filename = "wwwroot/Documents/Decrees/Synthetic_Decree.md";
            model.synth_decree_text = cls_markdown.ConvertMDtoTXT(filename);
            filename = "wwwroot/Documents/Decrees/genetic_modification.md";
            model.mod_text = cls_markdown.ConvertMDtoTXT(filename);

            return View(model);
        }
    }
}