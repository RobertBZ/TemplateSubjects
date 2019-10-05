using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextPatternDesigns.Houses
{
    public class IglooHouseBuilder : HouseBuilder
    {
        private House CurrentHouse;

        public IglooHouseBuilder()
        {
            this.CurrentHouse = new House();
        }

        public void BuildBasement()
        {
            CurrentHouse.SetBasement("Barras de hielo");
        }

        public void BuildInterior()
        {
            CurrentHouse.SetInterior("Tallado de hielo");
        }

        public void BuildStructure()
        {
            CurrentHouse.SetStructure("Bloques de hielo");
        }

        public void BulidRoof()
        {
            CurrentHouse.SetRoof("Domo de hielo");
        }

        public House GetHouse()
        {
            return this.CurrentHouse;
        }
    }
}
