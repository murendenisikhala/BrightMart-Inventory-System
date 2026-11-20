using Microsoft.Data.Sqlite;

namespace BrightMartInventorySystems
{
    public static class DatabaseManager
    {
        private static string connectionString =
            "Data Source=brightmart.db";

        public static void CreateDatabase()
        {
            using (SqliteConnection connection =
                new SqliteConnection(connectionString))
            {
                connection.Open();

                string sql = @"
                CREATE TABLE IF NOT EXISTS Products (
                    ProductID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProductName TEXT NOT NULL,
                    Price REAL NOT NULL,
                    Quantity INTEGER NOT NULL,
                    Supplier TEXT
                );

                CREATE TABLE IF NOT EXISTS Suppliers (
                    SupplierID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SupplierName TEXT NOT NULL,
                    Email TEXT,
                    Contact TEXT
                );

                CREATE TABLE IF NOT EXISTS Sales (
                    SaleID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProductName TEXT NOT NULL,
                    QuantitySold INTEGER NOT NULL,
                    TotalPrice REAL NOT NULL,
                    SaleDate TEXT NOT NULL
                );";

                using (SqliteCommand command =
                    new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddProduct(Product product)
        {
            using (SqliteConnection connection =
                new SqliteConnection(connectionString))
            {
                connection.Open();

                string sql = @"
            INSERT INTO Products
            (ProductName, Price, Quantity, Supplier)
            VALUES
            (@ProductName, @Price, @Quantity, @Supplier)
            RETURNING ProductID;";

                using (SqliteCommand command =
                    new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue(
                        "@ProductName", product.ProductName);

                    command.Parameters.AddWithValue(
                        "@Price", product.Price);

                    command.Parameters.AddWithValue(
                        "@Quantity", product.Quantity);

                    command.Parameters.AddWithValue(
                        "@Supplier", product.Supplier);

                    product.ProductID =
                        Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }




        public static void UpdateProduct(Product product)
        {
            using (SqliteConnection connection =
                new SqliteConnection(connectionString))
            {
                connection.Open();

                string sql = @"
                UPDATE Products
                SET ProductName = @ProductName,
                    Price = @Price,
                    Quantity = @Quantity,
                    Supplier = @Supplier
                WHERE ProductID = @ProductID;";

                using (SqliteCommand command =
                    new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue(
                        "@ProductName", product.ProductName);

                    command.Parameters.AddWithValue(
                        "@Price", product.Price);

                    command.Parameters.AddWithValue(
                        "@Quantity", product.Quantity);

                    command.Parameters.AddWithValue(
                        "@Supplier", product.Supplier);

                    command.Parameters.AddWithValue(
                        "@ProductID", product.ProductID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteProduct(int productId)
        {
            using (SqliteConnection connection =
                new SqliteConnection(connectionString))
            {
                connection.Open();

                string sql = @"
            DELETE FROM Products
            WHERE ProductID = @ProductID;";

                using (SqliteCommand command =
                    new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue(
                        "@ProductID", productId);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static void LoadProducts()
        {
            ProductData.Products.Clear();

            using (SqliteConnection connection =
                new SqliteConnection(connectionString))
            {
                connection.Open();

                string sql = @"
            SELECT ProductID, ProductName, Price, Quantity, Supplier
            FROM Products
            ORDER BY ProductID;";

                using (SqliteCommand command =
                    new SqliteCommand(sql, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product();

                            product.ProductID = reader.GetInt32(0);
                            product.ProductName = reader.GetString(1);
                            product.Price = Convert.ToDecimal(reader.GetDouble(2));
                            product.Quantity = reader.GetInt32(3);
                            product.Supplier = reader.IsDBNull(4)
                                ? ""
                                : reader.GetString(4);

                            ProductData.Products.Add(product);
                        }
                    }
                }
            }
        }
        public static void AddSupplier(Supplier supplier)
        {
            using (SqliteConnection connection =
                new SqliteConnection(connectionString))
            {
                connection.Open();

                string sql = @"
            INSERT INTO Suppliers
            (SupplierName, Email, Contact)
            VALUES
            (@SupplierName, @Email, @Contact)
            RETURNING SupplierID;";

                using (SqliteCommand command =
                    new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue(
                        "@SupplierName", supplier.SupplierName);

                    command.Parameters.AddWithValue(
                        "@Email", supplier.Email);

                    command.Parameters.AddWithValue(
                        "@Contact", supplier.Contact);

                    supplier.SupplierID =
                        Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }


        public static void UpdateSupplier(Supplier supplier)
        {
            using (SqliteConnection connection =
                new SqliteConnection(connectionString))
            {
                connection.Open();

                string sql = @"
            UPDATE Suppliers
            SET SupplierName = @SupplierName,
                Email = @Email,
                Contact = @Contact
            WHERE SupplierID = @SupplierID;";

                using (SqliteCommand command =
                    new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                    command.Parameters.AddWithValue("@Email", supplier.Email);
                    command.Parameters.AddWithValue("@Contact", supplier.Contact);
                    command.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteSupplier(int supplierId)
        {
            using (SqliteConnection connection =
                new SqliteConnection(connectionString))
            {
                connection.Open();

                string sql = @"
            DELETE FROM Suppliers
            WHERE SupplierID = @SupplierID;";

                using (SqliteCommand command =
                    new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@SupplierID", supplierId);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static void SaveSupplierIfNotExists(Supplier supplier)
        {
            using (SqliteConnection connection =
                new SqliteConnection(connectionString))
            {
                connection.Open();

                string checkSql = @"
            SELECT COUNT(*)
            FROM Suppliers
            WHERE SupplierName = @SupplierName;";

                using (SqliteCommand checkCommand =
                    new SqliteCommand(checkSql, connection))
                {
                    checkCommand.Parameters.AddWithValue(
                        "@SupplierName", supplier.SupplierName);

                    long count = (long)checkCommand.ExecuteScalar();

                    if (count == 0)
                    {
                        string insertSql = @"
                    INSERT INTO Suppliers
                    (SupplierName, Email, Contact)
                    VALUES
                    (@SupplierName, @Email, @Contact);";

                        using (SqliteCommand insertCommand =
                            new SqliteCommand(insertSql, connection))
                        {
                            insertCommand.Parameters.AddWithValue(
                                "@SupplierName", supplier.SupplierName);

                            insertCommand.Parameters.AddWithValue(
                                "@Email", supplier.Email);

                            insertCommand.Parameters.AddWithValue(
                                "@Contact", supplier.Contact);

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public static void LoadSuppliers()
        {
            SupplierData.Suppliers.Clear();

            using (SqliteConnection connection =
                new SqliteConnection(connectionString))
            {
                connection.Open();

                string sql = @"
            SELECT SupplierID, SupplierName, Email, Contact
            FROM Suppliers
            ORDER BY SupplierID;";

                using (SqliteCommand command =
                    new SqliteCommand(sql, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Supplier supplier = new Supplier();

                            supplier.SupplierID = reader.GetInt32(0);
                            supplier.SupplierName = reader.GetString(1);
                            supplier.Email = reader.IsDBNull(2)
                                ? ""
                                : reader.GetString(2);
                            supplier.Contact = reader.IsDBNull(3)
                                ? ""
                                : reader.GetString(3);

                            SupplierData.Suppliers.Add(supplier);
                        }
                    }
                }
            }
        }
        public static void AddSale(Sale sale)
        {
            using (SqliteConnection connection =
                new SqliteConnection(connectionString))
            {
                connection.Open();

                string sql = @"
            INSERT INTO Sales
            (ProductName, QuantitySold, TotalPrice, SaleDate)
            VALUES
            (@ProductName, @QuantitySold, @TotalPrice, @SaleDate)
            RETURNING SaleID;";

                using (SqliteCommand command =
                    new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue(
                        "@ProductName", sale.ProductName);

                    command.Parameters.AddWithValue(
                        "@QuantitySold", sale.QuantitySold);

                    command.Parameters.AddWithValue(
                        "@TotalPrice", sale.TotalPrice);

                    command.Parameters.AddWithValue(
                        "@SaleDate", sale.SaleDate.ToString("yyyy-MM-dd HH:mm:ss"));

                    sale.SaleID =
                        Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }
    

            
        
        public static void LoadSales()
        {
            SalesData.Sales.Clear();

            using (SqliteConnection connection =
                new SqliteConnection(connectionString))
            {
                connection.Open();

                string sql = @"
            SELECT SaleID, ProductName, QuantitySold, TotalPrice, SaleDate
            FROM Sales
            ORDER BY SaleID;";

                using (SqliteCommand command =
                    new SqliteCommand(sql, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Sale sale = new Sale();

                            sale.SaleID = reader.GetInt32(0);
                            sale.ProductName = reader.GetString(1);
                            sale.QuantitySold = reader.GetInt32(2);
                            sale.TotalPrice =
                                Convert.ToDecimal(reader.GetDouble(3));
                            sale.SaleDate =
                                DateTime.Parse(reader.GetString(4));

                            SalesData.Sales.Add(sale);
                        }
                    }
                }
            }
        }
    }
    
}
        
    

          
        
    

     
    

    
