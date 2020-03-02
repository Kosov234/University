using System;
using System.Collections.Generic;
using System.Text;

namespace Class7
{
    class Coconut:Fruit
    {
        public Coconut(string originCountry, double priceKg) : base(originCountry,priceKg)
        {
        }

        public override bool ContainsJuice()
        {
            return true;
        }
    }
}
