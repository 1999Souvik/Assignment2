using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{

    internal class Product
    {
        static int Prodid = 0;
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string UnitOfMeasurement { get; set; }
        public int Qty { get; set; }

        public Product() { 
            Prodid = Prodid + 1;
            ProductId = Prodid;
        }

        
    }

}
