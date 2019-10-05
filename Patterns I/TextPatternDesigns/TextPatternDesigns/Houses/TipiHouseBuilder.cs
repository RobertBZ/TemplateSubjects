using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextPatternDesigns.Houses
{
    public class TipiHouseBuilder : HouseBuilder
    {
        private House CurrentHouse;

        public TipiHouseBuilder()
        {
            this.CurrentHouse = new House();
        }

        public void BuildBasement()
        {
            CurrentHouse.SetBasement("Piso de madera");
        }

        public void BuildInterior()
        {
            CurrentHouse.SetInterior("Leña");
        }

        public void BuildStructure()
        {
            CurrentHouse.SetStructure("Hielo y madera");
        }

        public void BulidRoof()
        {
            CurrentHouse.SetRoof("Madera y pieles de animal");
        }

        public House GetHouse()
        {
            return this.CurrentHouse;
        }
    }
}
