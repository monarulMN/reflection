using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.SingletonExample
{
    public class Bus
    {
        public int SeatCount { get; set; }
        public double Speed { get; set; }

        private static Bus? _instance = null;
        private Bus() { }

        public static Bus CreateBus()
        {
            if( _instance == null)
            {
                _instance = new Bus();
            }

            return _instance;
        }
    }
}
