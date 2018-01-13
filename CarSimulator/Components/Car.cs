using CarSimulator.Interface;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarSimulator
{
    public class Car : ICar
    {
        private IBrake _handBrake;
        private IBrake _backBrake;
        private IEngine _engine;
        private ILight _light;
        private List<IWheel> _frontWheels;
        private List<IWheel> _backWheels;

        public Car([Named("HandBrake")]IBrake handBrake, [Named("BackBrake")]IBrake backBrake, IEngine engine, ILight light, [Named("frontWheels")]List<IWheel> frontWheels, [Named("backWheels")]List<IWheel> backWheels)
        {
            _handBrake = handBrake;
            _backBrake = backBrake;
            _engine = engine;
            _light = light;
            _frontWheels = frontWheels;
            _backWheels = backWheels;
        }

        public void Start()
        {
            _engine.Start(_frontWheels);
        }

        public void Stop()
        {
            _engine.Stop();
            _handBrake.Stop(_frontWheels);
            _backBrake.Stop(_backWheels);
        }
    }
}
