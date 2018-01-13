using CarSimulator.Interface;
using System;

namespace CarSimulator
{
    public class Wheel : IWheel
    {
        private int _id { get; set; }

        public Wheel(int id)
        {
            _id = id;
        }

        public void StartRotate()
        {
            Console.WriteLine($"Wheel {_id} is running.");
        }

        public void StopRotate()
        {
            Console.WriteLine($"Wheel {_id} is stopped.");
        }
    }
}