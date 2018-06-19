using HeyRed.MarkdownSharp;

namespace emperor_mvc.Classes
{
    public class cls_markdown
    {
        public static string ConvertMDtoTXT(string filename)
        {
            string text = System.IO.File.ReadAllText(filename);
            Markdown mark = new Markdown();

            return mark.Transform(text);
        }
    }
}