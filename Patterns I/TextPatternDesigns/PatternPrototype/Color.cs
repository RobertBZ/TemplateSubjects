using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrototype
{
    public abstract class Color : ICloneable
    {
        protected string ColorName;
        public abstract void AddColor();
        public object Clone()
        {
            object clone = null;
            try
            {
                clone = this.Clone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return clone;
        }
    }
}
