using CarSimulator;
using DependencyInjectionFrameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new ContainerRegistration());
            Car car = kernel.Get<Car>();
            car.Start();
        }
    }
}
