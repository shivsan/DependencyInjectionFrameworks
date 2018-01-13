using CarSimulator.Interface;
using System.Collections.Generic;

namespace CarSimulator
{
    public class BackBrake : IBrake
    {
        private List<IWheel> _wheels;

        public BackBrake(List<IWheel> wheels)
        {
            _wheels = wheels;
        }

        public void Stop()
        {
            _wheels.ForEach(w => w.StopRotate());
        }
    }
}