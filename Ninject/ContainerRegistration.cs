using CarSimulator;
using CarSimulator.Factory;
using CarSimulator.Interface;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionFrameworks
{
    class ContainerRegistration : NinjectModule
    {
        delegate List<Wheel> WheelPairGiver(int a, int b);

        public override void Load()
        {
            WheelPairGiver frontWheelDelegate = new WheelPairGiver(WheelFactory.GetWheelPair);
            Bind<ICar>().To<Car>().InSingletonScope();
            Bind<IEngine>().To<Engine>().InSingletonScope();
            Bind<IBrake>().To<Brake>().InSingletonScope().Named("HandBrake");
            Bind<IBrake>().To<Brake>().InSingletonScope().Named("BackBrake");
            Bind<IWheel>().To<Wheel>().InSingletonScope();
            Bind<ILight>().To<Light>().InSingletonScope();
        }
    }
}