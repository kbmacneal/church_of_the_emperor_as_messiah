using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using RestSharp;

namespace emperor3.Classes
{
    public class cls_rest
    {
        public string log_in ()
        {
            string url = "https://discordapp.com/api/oauth2/authorize?client_id=440328854091857922&redirect_uri=http%3A%2F%2Fhighchurch.space&response_type=code&scope=identify";
        }
        public List<string> InvokeRestMethod(string uri, string method)
        {
            List<string> rtn = new List<string>();

            RestSharp.RestRequest req = new RestRequest();
            

            return rtn;
        }
    }
}