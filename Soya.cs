using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Soya : Decorator
    {
        public Soya(Beverage beverage) : base(beverage)
        {
        }

        public override string Description { get => $"{beverage.Description} soya"; }
        public override double cost()
        {
            return 0.35f + beverage.cost();
        }
    }
}
