using PatternPrototype.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorStore.GetColor("Azul").AddColor();
            ColorStore.GetColor("Negro").AddColor();
            ColorStore.GetColor("Negro").AddColor();
            ColorStore.GetColor("Azul").AddColor();
        }
    }
}
