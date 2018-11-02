using System;
using emperor_mvc.Classes;
using Newtonsoft.Json;

namespace emperor_mvc.Classes {

    public class Feedback {
        public static void RegisterResponse (feedback feedback) {
            DataManager.insert_record (feedback);
        }
    }
}