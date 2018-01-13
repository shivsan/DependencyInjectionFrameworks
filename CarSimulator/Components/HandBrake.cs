using CarSimulator.Interface;
using System.Collections.Generic;

namespace CarSimulator
{
    public class Brake : IBrake
    {
        public void Stop(List<IWheel> wheels)
        {
            wheels.ForEach(w => w.StopRotate());
        }
    }
}