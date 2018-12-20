using System;

namespace emperor_mvc.Classes {
    public class response {
        public string EmailData { get; set; }
        public string IPData { get; set; }
        public Boolean CheckboxData { get; set; }

    }

    public class question {
        public string question_text { get; set; }
        public string UserID { get; set; }
    }

    public class feedback {
        public string FeedbackText { get; set; }
        public string UserName { get; set; }
    }

    public class cls_markdown {
        public static string ConvertMDtoTXT (string filename) {
            string text = System.IO.File.ReadAllText (filename);

            return CommonMark.CommonMarkConverter.Convert (text);
        }
    }
}