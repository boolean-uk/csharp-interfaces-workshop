
using VW.Factory.Cars;
using VW.Factory.Engines;
using VW.Factory.Interfaces;

namespace VW.Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEngine petrolEngine = new ElectricEngine();
            Beetle bug = new Beetle(petrolEngine);
            bug.StartEngine();
            

        }
    }
}