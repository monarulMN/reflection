using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryExample
{
    public class F16FighterFactory : FighterFactory
    {
        public override Bomb CreateBomb()
        {
            return new F16Bomb();
        }

        public override Fighter CreateFighter()
        {
            return new F16();
        }

        public override Missile CreateMissile()
        {
            return new F16Missile(); 
        }
    }
}
