using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class HouseBlendWithMilk:Beverage
    {
        public HouseBlendWithMilk()
        {
            Description = "Houseblend with milk ";
        }

        public override double cost()
        {
            return 3.5;
        }
    }
}
