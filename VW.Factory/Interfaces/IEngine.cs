using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW.Factory.Interfaces
{
    public interface IEngine
    {
        string Name { get; set; }

        bool Start(bool ishotweather);
    }
}
