using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryExample
{
    public class CarFactory
    {
        public Car CrateCar(string brand)
        {
            if(brand == "toyota")
            {
                return new Car { Model = "Corolla", Color ="Red", Speed = 120 };
            }
            else if(brand == " honda")
            {
                return new Car { Model = "Civic", Color = "Black", Speed = 140};
            }
            return new Car();
        }
    }
}
