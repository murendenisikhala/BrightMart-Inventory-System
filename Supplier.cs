using System;
using System.Collections.Generic;
using System.Text;

namespace BrightMartInventorySystems
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
    }

    public static class SupplierData
    {
        public static List<Supplier> Suppliers = new List<Supplier>();
    }
}
    

