using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class HouseBlend:Beverage
    {
        public HouseBlend()
        {
            Description = "Houseblend ";
        }

        public override double cost()
        {
            return 2.5;
        }
    }
}
