using System;
using System.Collections.Generic;
using System.Text;

namespace BrightMartInventorySystems
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Supplier { get; set; }
    }
    public static class ProductData
    {
        public static List<Product> Products = new List<Product>();
    }

}
