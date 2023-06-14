using System.IO;
using System.Web;
using System;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    public class UnicodeFileToHtmlTextConverter
    {
        //private readonly string _fullFilenameWithPath;
        public bool CheckFileExistence(string fullFilenameWithPath)
        {
            bool isFileExist = false;
            if (File.Exists(fullFilenameWithPath))
            {
                isFileExist = true;
            }
            return isFileExist;
        }

        public bool CheckFileExtensionisTXT(string fullFilenameWithPath)
        {
            bool isFileExtensionisText = false;
            string ext = Path.GetExtension(fullFilenameWithPath).ToLower();
            if (ext == ".txt")
            {
                isFileExtensionisText = true;

            }
            return isFileExtensionisText;

        }

        //public UnicodeFileToHtmlTextConverter(string fullFilenameWithPath)
        //{
        //    _fullFilenameWithPath = fullFilenameWithPath;
        //}

        public string ConvertToHtml(string fullFilenameWithPath)
        {
            string html = string.Empty;

            try
            {
                if (CheckFileExistence(fullFilenameWithPath)&& CheckFileExtensionisTXT(fullFilenameWithPath))
                {

                    using (TextReader unicodeFileStream = File.OpenText(fullFilenameWithPath))
                    {


                        string line = unicodeFileStream.ReadLine();
                        while (line != null)
                        {
                            html += HttpUtility.HtmlEncode(line);
                            html += "<br />";
                            line = unicodeFileStream.ReadLine();
                        }

                        return html;
                    }
                }
                else
                {
                    return html;
                }
            }
            catch (Exception ex)
            {
                return html;
            }

        }
    }
}
