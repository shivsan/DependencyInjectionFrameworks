using CarSimulator.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarSimulator.Factory
{
    public class WheelFactory
    {
        public static List<Wheel> GetWheelPair(int id1, int id2)
        {
            return new List<Wheel>
            {
                new Wheel(id1),
                new Wheel(id2)
            };
        }
    }
}
