using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrototype.Colors
{
    public class BlueColor : Color
    {
        public BlueColor()
        {
            this.ColorName = "Azul";
        }
        public override void AddColor()
        {
            Console.WriteLine("Color Azul Agregado");
        }
    }
}
