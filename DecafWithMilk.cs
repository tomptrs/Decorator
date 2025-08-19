using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class DecafWithMilk:Beverage
    {
        public DecafWithMilk()
        {
            Description = "Decaf with milk";
        }

        public override double cost()
        {
            return 4.5;
        }
    }
}
