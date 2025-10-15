using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Espresso: Beverage
    {
        public Espresso()
        {
            
        }

        public override string Description { get => "Espresso"; }

        public override double cost()
        {
            return 1.75;
        }
    }
}
