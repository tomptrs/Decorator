using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class Decorator : Beverage
    {
        protected Beverage beverage;

      

        protected Decorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

    }
}
