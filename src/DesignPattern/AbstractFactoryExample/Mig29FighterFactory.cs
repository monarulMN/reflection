using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryExample
{
    public class Mig29FighterFactory : FighterFactory
    {
        public override Bomb CreateBomb()
        {
            return new Mig29Bomb();
        }

        public override Fighter CreateFighter()
        {
            return new Mig29();
        }

        public override Missile CreateMissile()
        {
            return new Mig29Missile();
        }
    }
}
