using System;
using System.Collections.Generic;
using System.Text;

namespace Class7
{
    class Banana:Fruit
    {
        public Banana(string originCountry,double priceKg) : base(originCountry,priceKg)
        {}

        public override bool ContainsJuice()
        {
            return false;
        }

        public override double GetPricePerKg()
        {
            return PricePerKg*5;
        }
    }
}
