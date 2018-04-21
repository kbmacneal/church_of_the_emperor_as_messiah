using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using emperor3.Sermons;


namespace emperor3
{
    public partial class SermonOne : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var filename = Server.MapPath("ideas.md");
            //string filename = "~/ideas.md";

            cls_markdown cls1 = new cls_markdown();

            sermon_header.InnerText = "Test Sermon";

            sermon_text.InnerHtml = cls_markdown.ConvertMDtoTXT(filename);
        }
    }
}