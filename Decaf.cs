using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Decaf:Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }

        public override double cost()
        {
           return 3.5;
        }
    }
}
