using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.basketexample.Interfaces;

namespace workshop.basketexample.Products
{
    public class Guitar : IProduct
    {
        public int NumberOfStrings { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
