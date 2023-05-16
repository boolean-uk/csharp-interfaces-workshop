using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VW.Factory.Interfaces;

namespace VW.Factory.Cars
{
    public class Beetle
    {
        private IEngine _engine;
        public Beetle(IEngine engine)
        {
            _engine = engine;
        }

        public bool StartEngine()
        {
            bool ishot = true;
            return _engine.Start(ishot);
        }

    }
}
