using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Milk : Decorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {
        }
      
        public override string Description { 
            get => $"{beverage.Description} Milk"; 
        }
    

        public override double cost()
        {
           return 0.3f + beverage.cost();
        }
    }
}
