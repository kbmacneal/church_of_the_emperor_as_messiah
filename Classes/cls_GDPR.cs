using System;
using Newtonsoft.Json;
using emperor_mvc.Classes;

namespace emperor_mvc.Classes{

    public class GDPR
    {
        public static void RegisterResponse(response response)
        {
            DataManager.insert_record(response);
        }
    }
}