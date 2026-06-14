using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Laptop : Product
    {
        public Laptop(int id, string name, double price) : base(id, name, price)
        {
        }

        public override double GetDiscountedPrice(double discountPercentage)
        {
            
            double discountPrice = base.GetDiscountedPrice(discountPercentage);
            return discountPrice - 15;
        }
    }
}
