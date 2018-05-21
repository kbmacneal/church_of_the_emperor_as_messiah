using HeyRed.MarkdownSharp;

namespace church_of_the_emporer_as_messiah.Sermons
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