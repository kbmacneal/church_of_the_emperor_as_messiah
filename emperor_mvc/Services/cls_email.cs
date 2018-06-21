using System;
using System.IO;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;
using Newtonsoft.Json;

namespace emperor_mvc.Services
{
    public class MailMessage
    {
        private class secrets{
            public string EmailUsername{get;set;}
            public string EmailPassword{get;set;}
        }
        public Boolean send_email(MimeMessage message)
        {
            SmtpClient client = new SmtpClient();

            secrets secret = JsonConvert.DeserializeObject<secrets>(System.IO.File.ReadAllText(@"../secrets.json"));

            try
            {
                client.Connect("smtp.gmail.com",587,false);
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                throw;
            }
            
            try
            {
                client.Authenticate(secret.EmailUsername,secret.EmailPassword);
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                throw;
            }

            try
            {
                client.Send(message);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
                return false;
            }           

            return true;
        }
    }

}