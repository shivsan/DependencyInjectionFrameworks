using CarSimulator.Interface;
using System.Collections.Generic;

namespace CarSimulator
{
    public class Engine: IEngine
    {
        private bool _state;
        public bool State { get => _state; }
        
        public void Start(List<IWheel> wheels)
        {
            _state = true;
            wheels.ForEach(w => w.StartRotate()); 
        }

        public void Stop()
        {
            _state = false;
        }
    }
}