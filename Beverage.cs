using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class Beverage
    {
        public abstract string Description { get; }


        public abstract double cost();
       
        public override string ToString()
        {
            return Description + " " + cost().ToString();
        }
    }
}
