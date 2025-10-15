using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class DarkRoast:Beverage
    {
        public DarkRoast()
        {
            Description = "DarkRoast coffee";
        }

        public override double cost()
        {
            return  3f ;
        }
    }
}
