using emperor_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace emperor_mvc.Controllers
{
    public class AudioController : Controller
    {
        public IActionResult Index(AudioModel model)
        {
            model.path = "https://highchurch.space/Assets/Audio/test.mp3";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult Meeting(AudioModel model)
        {
            model.path = "https://highchurch.space/Assets/Audio/Meeting.mp3";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult MeetingTwo(AudioModel model)
        {
            model.path = "https://highchurch.space/Assets/Audio/Meeting2.mp3";
            model.set_html();
            return View("Index", model);
        }

        public IActionResult EnemiesEmpire(AudioModel model)
        {
            model.path = "https://highchurch.space/Assets/Audio/Sermons/enemies_of_the_empire.m4a";
            model.set_html();
            return View("Index", model);
        }
    }
}