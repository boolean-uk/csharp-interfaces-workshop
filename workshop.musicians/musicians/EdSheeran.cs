using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.musicians.interfaces;

namespace workshop.musicians.musicians
{
    public class EdSheeran : IPerson, IGuitar, ISing
    {
        public string Name { get; set; }

        public void PlayGuitar()
        {
            throw new NotImplementedException();
        }

        public void Sing()
        {
            throw new NotImplementedException();
        }
    }
}
