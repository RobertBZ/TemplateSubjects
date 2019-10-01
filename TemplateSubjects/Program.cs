using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateSubjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = UtilPfd.GetData(@"C:\Users\Robert\Desktop\Usip\6to Semestre\TS I\TS I\Classroom\Horarios Sistemas II-2019.pdf");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
