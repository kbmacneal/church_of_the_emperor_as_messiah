using System;
using Newtonsoft.Json;
using emperor_mvc.Classes;

namespace emperor_mvc.Classes{

    public class Question
    {
        public static void RegisterResponse(question question)
        {
            DataManager.insert_record(question);
        }
    }
}