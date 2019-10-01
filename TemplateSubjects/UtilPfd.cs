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
        public static string GetData(string pdfFileName)
        {
            StringBuilder result = new StringBuilder();
            PdfReader reader = new PdfReader(pdfFileName);
            string pageText;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                pageText = PdfTextExtractor.GetTextFromPage(reader, page);
                result.Append(UseText(pageText));
            }
            reader.Close();
            return result.ToString();
        }

        public static string UseText(string page)
        {
            StringBuilder Line = new StringBuilder();
            string[] splittedText = page.Split('\n');
            string text;
            foreach (string textLine in splittedText)
            {
                if (textLine != "" && textLine != "(*)")
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

        public static void TextToModel(string text)
        {
            Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.IgnoreCase | RegexOptions.Compiled);

            MatchCollection matches = rx.Matches(text);

            for (int ctr = 0; ctr < matches.Count; ctr++)
            {
                Console.WriteLine("{0} repeated at positions and",
                                  matches[ctr].Value);
                Console.ReadKey();
            }
        }
    }
}
