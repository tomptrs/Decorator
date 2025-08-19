using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class HouseBlendWithSoya:Beverage
    {
        public HouseBlendWithSoya()
        {
            Description = "Houseblend with soya ";
        }

        public override double cost()
        {
            return 4;
        }
    }
}
