using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBridge.Vehicles
{
    public class Bike : Vehicle
    {
        public Bike(Workshop workshop1, Workshop workshop2) :
            base(workshop1, workshop2)
        { }

        public override void manufacture()
        {
            Console.WriteLine("Bici ");
            Workshop1.Work();
            Workshop2.Work();
        }
    }
}
