using System;
using System.Collections.Generic;
using System.Text;

namespace BrightMartInventorySystems
{
    public class Sale
    {
        public int SaleID { get; set; }
        public string ProductName { get; set; }
        public int QuantitySold { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime SaleDate { get; set; }
    }
    public static class SalesData
    {
        public static List<Sale> Sales = new List<Sale>();
    }
}
