using System;
using System.Collections.Generic;
using System.Text;

using System.Text.Json;

namespace BrightMartInventorySystems
{
    public class DataManager
    {
        private static string productsFile = "products.json";
        private static string salesFile = "sales.json";
        private static string suppliersFile = "suppliers.json";

        public static void SaveData()
        {
            string productsJson = JsonSerializer.Serialize(ProductData.Products);
            File.WriteAllText(productsFile, productsJson);

            string salesJson = JsonSerializer.Serialize(SalesData.Sales);
            File.WriteAllText(salesFile, salesJson);

            string suppliersJson = JsonSerializer.Serialize(SupplierData.Suppliers);
            File.WriteAllText(suppliersFile, suppliersJson);
        }
        public static void LoadData()
        {

            if (File.Exists(productsFile))
            {
                string productsJson = File.ReadAllText(productsFile);
                ProductData.Products = JsonSerializer.Deserialize<List<Product>>(productsJson)
                    ?? new List<Product>();
            }

            if (File.Exists(salesFile))
            {
                string salesJson = File.ReadAllText(salesFile);
                SalesData.Sales = JsonSerializer.Deserialize<List<Sale>>(salesJson)
                    ?? new List<Sale>();
            }
            if (File.Exists(suppliersFile))
            {
                string suppliersJson = File.ReadAllText(suppliersFile);

                SupplierData.Suppliers =
                    JsonSerializer.Deserialize<List<Supplier>>(suppliersJson)
                    ?? new List<Supplier>();
            }
        }
    }
}
