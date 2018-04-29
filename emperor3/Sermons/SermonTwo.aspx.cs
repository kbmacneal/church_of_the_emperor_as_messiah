using emperor3.Sermons;
using System;
using System.Web.UI;

namespace emperor3
{
    public partial class SermonTwo : Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Request.Browser.IsMobileDevice)
                MasterPageFile = "~/Site.Mobile.Master";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var filename = Server.MapPath("SermonTwo.md");
            //string filename = "~/ideas.md";

            cls_markdown cls1 = new cls_markdown();

            sermon_header.InnerText = "";

            sermon_text.InnerHtml = cls_markdown.ConvertMDtoTXT(filename);
        }
    }
}