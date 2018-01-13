using System.Collections.Generic;

namespace CarSimulator.Interface
{
    public interface IBrake
    {
        void Stop(List<IWheel> wheels);
    }
}