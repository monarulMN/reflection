using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.PrototypeExample
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product Copy()
        {
            return new Product
            {
                Name = Name,
                Price = Price
            };
        }
    }
}
