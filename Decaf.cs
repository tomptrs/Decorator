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
           
        }

     
        public override string Description { get => "decaf"; }

        public override double cost()
        {
            return  4f;
        }
    }
}
