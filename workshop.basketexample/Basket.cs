using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.basketexample.Interfaces;

namespace workshop.basketexample
{
    public class Basket
    {
        private List<IProduct> _products = new List<IProduct>();

        public void Add(IProduct product)
        {
            _products.Add(product);
        }

        public List<IProduct> Products { get { return _products; } }
    }
}
