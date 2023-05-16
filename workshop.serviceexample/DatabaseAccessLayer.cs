using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.serviceexample.Interface;

namespace workshop.serviceexample
{
    public class DatabaseAccessLayer
    {
        IDatabaseProvider _provider;
        public DatabaseAccessLayer(IDatabaseProvider provider)
        {
            _provider = provider;
        }

        public void DeleteRecordsFromProvider()
        {
            _provider.DeleteRecords();
        }
        public void UpdateRecordsFromProvider()
        {
            _provider.UpdateRecords();

        }
        public void SelectRecordsFromProvider()
        {
            _provider.SelectRecords();
        }
    }
}
