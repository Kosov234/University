using System;
using System.Collections.Generic;
using System.Text;

namespace Class7
{
    public abstract class Fruit
    {
        public Fruit(string originCountry,double pricePerKg)
        {
            OriginCountry = originCountry;
            PricePerKg = pricePerKg;
        }

        public string OriginCountry { get; protected set; }
        public double PricePerKg { get; protected set; }
        public abstract bool ContainsJuice();
        public virtual double GetPricePerKg()
        {
            return PricePerKg;
        }
    }
}
