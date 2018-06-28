using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace emperor_mvc.Models
{
    public class FeedbackModel
    {
        public string FeedbackText{get;set;}
        public string UserName{get;set;}
        
    }
}