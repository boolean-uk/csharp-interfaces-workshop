using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.basketexample.Interfaces
{
    //starts with capital
    //is a contract?
    //defines behaviour

    public interface IProduct
    {
        string Name { get; set; }
        int Price { get; set; }
    }
}
