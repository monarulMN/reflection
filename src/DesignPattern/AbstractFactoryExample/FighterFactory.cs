using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryExample
{
    public abstract class FighterFactory
    {
        public abstract Fighter CreateFighter();
        public abstract Missile CreateMissile();
        public abstract Bomb CreateBomb();
    }
}
