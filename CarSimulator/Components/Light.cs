using CarSimulator.Interface;

namespace CarSimulator
{
    public class Light: ILight
    {
        private bool _state;
        public bool State { get => _state; }

        public void On()
        {
            _state = true;
        }

        public void Off()
        {
            _state = false;
        }
    }
}