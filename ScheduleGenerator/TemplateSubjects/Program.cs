using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateSubjects.Models;

namespace TemplateSubjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = UtilPfd.ReadPDF(@"C:\Users\Robert\Desktop\Usip\6to Semestre\TS I\TemplateSubjects\ScheduleGenerator\TemplateSubjects\Resources\Horarios Sistemas II-2019.pdf");
            List<Subject> subjects = DataParser.Signatures(res);
            foreach (Subject sub in subjects)
            {
                Console.WriteLine(sub);
            }
            Console.ReadKey();
        }
    }
}
