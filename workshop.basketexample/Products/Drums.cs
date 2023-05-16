using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.basketexample.Interfaces;

namespace workshop.basketexample.Products
{
    public class Drums : IProduct
    {
        public bool ComesWithFreeDrumsticks { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
