using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Book : Product
    {
        public Book(int id, string name, double price) : base(id, name, price)
        {
        }

        public override double GetDiscountedPrice(double discountPercentage)
        {
            double discountedPrice =  base.GetDiscountedPrice(discountPercentage);
            return discountedPrice - 20;

        }
    }
}
