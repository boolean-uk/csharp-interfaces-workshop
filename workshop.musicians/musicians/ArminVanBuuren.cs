using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.musicians.interfaces;

namespace workshop.musicians.musicians
{
    public class ArminVanBuuren : IPerson, IDj
    {
        public string Name { get; set; }

        public void CanMix()
        {
            throw new NotImplementedException();
        }
    }
}
