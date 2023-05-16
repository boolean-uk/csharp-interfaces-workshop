using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.serviceexample.Interface;

namespace workshop.serviceexample.Providers
{
    public class GoogleDBService : IDatabaseProvider
    {
        public void DeleteRecords()
        {
            Console.WriteLine("Google Delete Methods");
        }

        public void SelectRecords()
        {
            Console.WriteLine("Google Select Methods");
        }

        public void UpdateRecords()
        {
            Console.WriteLine("Google Update Methods");
        }
    }
}
