using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TemplateSubjects
{
    public static class UtilPfd
    {
        public static string ReadPDF(string pdfFileName)
        {
            StringBuilder result = new StringBuilder();
            PdfReader reader = new PdfReader(pdfFileName);
            string pageText;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                pageText = PdfTextExtractor.GetTextFromPage(reader, page);
                result.Append(GetData(pageText));
            }
            reader.Close();
            return result.ToString();
        }

        public static string GetData(string page)
        {
            StringBuilder Line = new StringBuilder();
            var splittedText = page.Split('\n');
            string text;
            foreach (string textLine in splittedText)
            {
                if (textLine != "(*)")
                {
                    char secondChar = textLine.ToCharArray().ElementAt(1);
                    char thirdChar = textLine.ToCharArray().ElementAt(2);
                    if (char.IsNumber(secondChar) && char.IsNumber(thirdChar))
                    {
                        text = textLine + '\n';
                        Line.Append(text);
                    }
                }
            }
            return Line.ToString();
        }
    }
}
