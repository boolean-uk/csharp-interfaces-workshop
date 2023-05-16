using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VW.Factory.Interfaces;

namespace VW.Factory.Engines
{
    public class PetrolEngine : IEngine
    {
        public string Name { get; set; }

        public bool Start(bool ishotweather)
        {
            return ishotweather==true ? true : false;
        }
    }
}
