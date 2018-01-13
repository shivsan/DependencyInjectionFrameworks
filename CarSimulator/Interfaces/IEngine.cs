using System.Collections.Generic;

namespace CarSimulator.Interface
{
    public interface IEngine
    {
        void Start(List<IWheel> wheels);
        void Stop();
    }
}