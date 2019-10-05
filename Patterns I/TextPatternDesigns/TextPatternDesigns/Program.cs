using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextPatternDesigns.Houses;

namespace TextPatternDesigns
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseBuilder iglooBuilder = new IglooHouseBuilder();
            CivilEngineer engineer = new CivilEngineer(iglooBuilder);

            engineer.constructHouse();

            House house = engineer.getHouse();

            Console.WriteLine("En contrucción: " + house);
            Console.ReadKey();
        }
    }
}
