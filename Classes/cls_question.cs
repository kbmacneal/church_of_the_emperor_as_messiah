using System;
using emperor_mvc.Classes;
using Newtonsoft.Json;

namespace emperor_mvc.Classes {

    public class Question {
        public static void RegisterResponse (question question) {
            DataManager.insert_record (question);
        }
    }
}