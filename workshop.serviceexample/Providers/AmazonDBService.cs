using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.serviceexample.Interface;

namespace workshop.serviceexample.Providers
{
    public class AmazonDBService : IDatabaseProvider
    {
        public void DeleteRecords()
        {
            Console.WriteLine("Deleting Records Amazon DB");
        }

        public void SelectRecords()
        {
            Console.WriteLine("Select Records Amazon DB");
        }

        public void UpdateRecords()
        {
            Console.WriteLine("Updating Records Amazon DB");
        }
    }
}
