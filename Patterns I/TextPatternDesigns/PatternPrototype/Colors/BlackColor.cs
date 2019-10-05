using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrototype.Colors
{
    class BlackColor : Color
    {
        public BlackColor()
        {
            this.ColorName = "Negro";
        }

        public override void AddColor()
        {
            Console.WriteLine("Color negro agregado");
        }
    }
}
