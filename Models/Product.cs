using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpCashier.Models
{
    internal class Product
    {
        public string name;
        public float price;
        public Product(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

    }
}
