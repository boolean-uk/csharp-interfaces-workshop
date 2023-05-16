using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using workshop.musicians.interfaces;

namespace workshop.musicians.musicians
{
    public class JayZ : IPerson, IRap
    {
        public string Name { get; set; }

        public void SpitsSomeRap()
        {
            Console.WriteLine("Rapping");
        }
    }
}
