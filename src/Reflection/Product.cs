using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public virtual double GetDiscountedPrice(double discountPercentage)
        {
            return Price - (Price * discountPercentage / 100);
        }

    }
}
