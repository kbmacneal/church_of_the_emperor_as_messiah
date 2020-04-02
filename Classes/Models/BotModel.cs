using System.Collections.Generic;

namespace emperor_mvc.Models
{
    public class command_help
    {
        public string name { get; set; }
        public string summary { get; set; }
        public bool admin_required { get; set; }
    }

    public class BotModel
    {
        public List<command_help> commands { get; set; }
    }
}