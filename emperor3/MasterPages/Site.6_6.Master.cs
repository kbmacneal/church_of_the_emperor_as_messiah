using System;
using System.Web.UI;

namespace emperor3
{
    public partial class Site6_6Master : MasterPage
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Request.Browser.IsMobileDevice)
                MasterPageFile = "~/Site.Mobile.Master";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}