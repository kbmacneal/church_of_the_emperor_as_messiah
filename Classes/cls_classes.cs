using System;

namespace emperor_mvc.Classes
{
    public class response
    {
        public string EmailData { get; set; }
        public string IPData { get; set; }
        public Boolean CheckboxData { get; set; }
    }

    public class question
    {
        public string question_text { get; set; }
        public string UserID { get; set; }
    }

    public class feedback
    {
        public string FeedbackText { get; set; }
        public string UserName { get; set; }
    }

    public class cls_markdown
    {
        public static string ConvertMDtoTXT(string filename)
        {
            string text = System.IO.File.ReadAllText(filename);

            return CommonMark.CommonMarkConverter.Convert(text);
        }
    }

    public class Feedback
    {
        public static void RegisterResponse(feedback feedback)
        {
            DataManager.insert_record(feedback);
        }
    }

    public class GDPR
    {
        public static void RegisterResponse(response response)
        {
            DataManager.insert_record(response);
        }
    }

    public class Question
    {
        public static void RegisterResponse(question question)
        {
            DataManager.insert_record(question);
        }
    }
}