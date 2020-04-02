namespace emperor_mvc.Models
{
    public class DownloadModel
    {
        public string path { get; set; }

        public string html { get; set; }

        public string link_html { get; set; }

        public void set_html()
        {
            this.link_html = "<a class=\"mx-auto d-block\" href=\"" + this.path + "\" target=\"_blank\">Link to Audio File</a>";
        }
    }
}