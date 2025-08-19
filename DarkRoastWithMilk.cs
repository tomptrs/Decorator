using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class DarkRoastWithMilk:Beverage
    {
        public DarkRoastWithMilk()
        {
            Description = "DarkRoast coffee";
        }

        public override double cost()
        {
            return 3;
        }
    }
}
