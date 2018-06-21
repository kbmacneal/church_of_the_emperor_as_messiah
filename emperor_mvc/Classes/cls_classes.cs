using System;

namespace emperor_mvc.Classes
{
    public class response
    {
        public string EmailData { get; set; }
        public string IPData { get; set; }
        public Boolean CheckboxData { get; set; }

    }

    public class user
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string salt_text { get; set; }
        public int confirm_number{get;set;}

        public Boolean confirmed {get;set;} = false;
        public user()
        {
            Random rng = new Random();
            this.confirm_number = rng.Next(0,1000);
        }
    }

   


}