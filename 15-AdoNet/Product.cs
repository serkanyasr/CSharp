using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    // Product class definition representing the basic properties of a product
    public class Product
    {
        // Unique identifier for the product
        public int Id { get; set; }

        // Name of the product
        public string Name { get; set; }

        // Unit price of the product
        public decimal UnitPrice { get; set; }

        // Stock amount or quantity of the product
        public int StockAmount { get; set; }
    }
}
