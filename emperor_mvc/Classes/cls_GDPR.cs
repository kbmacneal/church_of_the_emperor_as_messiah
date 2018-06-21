using System;
using Newtonsoft.Json;
using emperor_mvc.Classes;

namespace emperor_mvc.Classes{

    public class GDPR
    {
        public static void RegisterResponse(response response)
        {
            DataManager.insert_response(response);

            // string serialized = JsonConvert.SerializeObject(response);

                // string name = response.EmailData.Split('@')[0];

                // if(!System.IO.Directory.Exists("wwwroot/GDPR"))
                // {
                //     System.IO.Directory.CreateDirectory("wwwroot/GDPR");
                // }

                // System.IO.File.WriteAllText(System.IO.Path.Combine("wwwroot/GDPR",name + ".json"),serialized);
        }
    }
}