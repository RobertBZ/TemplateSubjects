using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateSubjects.Models
{
    public class Subject
    {
        public int IdSubject { get; set; }
        public string SubjectName { get; set; }
        public string Group { get; set; }
        //public List<Schedule> Schedules { get; set; }
        public string Day { get; set; }
        public int StartHour { get; set; }
        public int EndHour { get; set; }
        public string ClassRoom { get; set; }
        public string ProffesorName { get; set; }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", 
                                  this.IdSubject,
                                  this.SubjectName,
                                  this.Group,
                                  this.Day,
                                  this.StartHour,
                                  this.EndHour,
                                  this.ClassRoom,
                                  this.ProffesorName);
        }
    }
}
