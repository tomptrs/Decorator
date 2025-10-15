using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class DarkRoast:Beverage
    {
        public DarkRoast()
        {
           
        }

        public override string Description { get => "dark roast"; }

        public override double cost()
        {
            return  3f ;
        }
    }
}
