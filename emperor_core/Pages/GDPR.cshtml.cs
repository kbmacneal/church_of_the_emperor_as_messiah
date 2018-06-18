using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using church_of_the_emporer_as_messiah.Sermons;
using System.Web;
using Microsoft.AspNetCore.Hosting;

namespace church_of_the_emporer_as_messiah.Pages
{
    public class GDPRModel : PageModel
    {
         public string TextBoxStringData { get; set; }

        public int TextBoxIntData { get; set; }

        public bool CheckboxData { get; set; }
        
        public void OnGet()
        {
            
        }

        public void b_submit_Click(object sender, EventArgs e){

        }
    }
}