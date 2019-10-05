using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TemplateSubjects.Models;

namespace TemplateSubjects
{
    public static class DataParser
    {
        public static List<Subject> Signatures(string text)
        {
            var splittedText = text.Split('\n');
            List<Subject> subjects = new List<Subject>();
            foreach (string textLine in splittedText)
            {
                
                if(textLine != "")
                {
                    Subject currentSubject = new Subject()
                    {
                        IdSubject = int.Parse(TextToModel(textLine, @"([0-9]){7}")),
                        SubjectName = TextToModel(textLine, @"[A-Z][^\d]+ \b").ToString(),
                        Group = TextToModel(textLine, @"\b[A-Z]\d\b|\b[0-9]{2}\b|\b[0-9]\b|\b[0-9][A-Z]\b|\b[EDC]\b").ToString(),
                        Day = TextToModel(textLine, @"\b(?:LU|MA|MI|JU|VI|SA|DO)\b"),
                        StartHour = int.Parse(TextToModel(textLine, @"\b[0-9]{4}\b|\b[0-9]{3}\b")),
                        EndHour = int.Parse(TextToModel(textLine, @"\b[0-9]{4}(?!-)\b|\b[0-9]{3}(?!-)\b")),
                        ClassRoom = TextToModel(textLine, @"\([0-9]+\)|\([0-9]+[A-Z]\)"),
                        ProffesorName = TextToModel(textLine, @"\)([A-Z\s])+").Remove(0, 2)
                    };
                    
                    subjects.Add(currentSubject);
                }
            }

            return subjects;
        }

        public static string TextToModel(string Line, string expression)
        {
            string result = "";
            Regex rx = new Regex(expression,
                                 RegexOptions.RightToLeft | RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(Line);

            foreach (Match match in matches)
            {
                result = match.Value;
            }
            return result;
        }
    }
}
