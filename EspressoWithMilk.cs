using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class EspressoWithMilk:Beverage
    {
        public EspressoWithMilk()
        {
            Description = "espresso with milk ";
        }

        public override double cost()
        {
            return 2.75;
        }
    }
}
