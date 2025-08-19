using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class DecafWithSoya:Beverage
    {
        public DecafWithSoya()
        {
            Description = "Decaf with soya";
        }

        public override double cost()
        {
            return 5;
        }
    }
}
