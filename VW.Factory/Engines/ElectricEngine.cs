using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VW.Factory.Interfaces;

namespace VW.Factory.Engines
{
    public class ElectricEngine : IEngine
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Start(bool ishotweather)
        {
            Console.WriteLine("Electric!");
            return true;
        }
    }
}
