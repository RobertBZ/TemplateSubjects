using PatternBridge.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Car(new Produced(), new Assemble());
            vehicle1.manufacture();
            Vehicle vehicle2 = new Bike(new Produced(), new Assemble());
            vehicle2.manufacture();

            Console.ReadKey();
        }
    }
}
