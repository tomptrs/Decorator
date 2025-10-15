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
           
        }

        public override string Description { get => "House blend"; }

        public override double cost()
        {
            return 2.5;
        }
    }
}
