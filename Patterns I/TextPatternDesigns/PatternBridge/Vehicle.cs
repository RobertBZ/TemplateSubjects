using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBridge
{
    public abstract class Vehicle
    {
        protected Workshop Workshop1;
        protected Workshop Workshop2;
        protected Vehicle(Workshop workshop1, Workshop workshop2)
        {
            this.Workshop1 = workshop1;
            this.Workshop2 = workshop2;
        }

        abstract public void manufacture();
    }
}
