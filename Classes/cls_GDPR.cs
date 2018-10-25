using System;
using emperor_mvc.Classes;
using Newtonsoft.Json;

namespace emperor_mvc.Classes {

    public class GDPR {
        public static void RegisterResponse (response response) {
            DataManager.insert_record (response);
        }

        
    }
}