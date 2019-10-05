using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextPatternDesigns
{
    public class House : HousePlan
    {
        private string Basement;
        private string Structure;
        private string Roof;
        private string Interior;
        public void SetBasement(string basement)
        {
            this.Basement = basement;
        }

        public void SetInterior(string interior)
        {
            this.Interior = interior;
        }

        public void SetRoof(string roof)
        {
            this.Roof = roof;
        }

        public void SetStructure(string structure)
        {
            this.Structure = structure;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", this.Basement, this.Structure, this.Roof, this.Interior);
        }
    }
}
