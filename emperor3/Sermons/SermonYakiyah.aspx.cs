using emperor3.Sermons;
using System;
using System.Web.UI;

namespace emperor3
{
    public partial class SermonYakiyah : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var filename = Server.MapPath("sermonyakiyah1.md");
            //string filename = "~/ideas.md";

            sermon_header.InnerText = "Preamble";

            sermon_text.InnerHtml = cls_markdown.ConvertMDtoTXT(filename);

            var filename2 = Server.MapPath("sermonyakiyah2.md");

            sermon_header_right.InnerText = "Sermon";

            sermon_text_right.InnerHtml = cls_markdown.ConvertMDtoTXT(filename2);
        }
    }
}