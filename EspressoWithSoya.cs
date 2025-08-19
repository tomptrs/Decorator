using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class EspressoWithSoya:Beverage
    {
        public EspressoWithSoya()
        {
            Description = "espresso with soya ";
        }

        public override double cost()
        {
            return 3.25;
        }
    }
}
