using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextPatternDesigns
{
    public class CivilEngineer
    {
        private HouseBuilder houseBuilder;

        public CivilEngineer(HouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        public House getHouse()
        {
            return this.houseBuilder.GetHouse();
        }

        public void constructHouse()
        {
            this.houseBuilder.BuildBasement();
            this.houseBuilder.BuildStructure();
            this.houseBuilder.BulidRoof();
            this.houseBuilder.BuildInterior();
        }
    }
}
