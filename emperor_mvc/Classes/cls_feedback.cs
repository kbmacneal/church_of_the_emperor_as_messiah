using System;
using Newtonsoft.Json;
using emperor_mvc.Classes;

namespace emperor_mvc.Classes{

    public class Feedback
    {
        public static void RegisterResponse(feedback feedback)
        {
            DataManager.insert_record(feedback);
        }
    }
}