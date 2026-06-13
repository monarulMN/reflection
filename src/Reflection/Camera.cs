using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Camera : Product
    {
        public Camera(int id, string name, double price) : base(id, name, price)
        {
        }

        public override double GetDiscountedPrice(double discountPercentage)
        {
            double discountedPrice = base.GetDiscountedPrice(discountPercentage);

            return discountedPrice - 10;
        }
    }
}
