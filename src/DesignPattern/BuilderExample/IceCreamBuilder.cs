using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderExample
{
    public class IceCreamBuilder
    {
        private IceCream _iceCream;

        public IceCreamBuilder()
        {
            _iceCream = new IceCream();
        }

        public void AddToppings(string topping) { }

        public void SetFlavor(string flavor) { }

        public void setSize(string size) { }
        
        public IceCream Make()
        {
            return _iceCream;
        }
    }
}
