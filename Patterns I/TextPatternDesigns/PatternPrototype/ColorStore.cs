using PatternPrototype.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrototype
{
    public class ColorStore
    {
        private static Dictionary<string, Color> ColorMap = new Dictionary<string, Color>();
        public ColorStore()
        {
            
        }

        public static Color GetColor(string colorName)
        {
            ColorMap.Add("Azul", new BlueColor());
            ColorMap.Add("Negro", new BlackColor());
            Console.WriteLine(colorName);
            return (Color)ColorMap[colorName].Clone();
        }
    }
}
