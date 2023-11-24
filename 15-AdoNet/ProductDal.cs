using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdoNet
{
    public class ProductDal
    {
        // SqlConnection object for connecting to the SQL Server database.
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; initial catalog=ETrade; integrated security=true");

        // Method that returns all products as List<Product>.
        public List<Product> Getall()
        {
            // Check and open the database connection.
            ConnectionControl();

            // Create a SQL query.
            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);

            // Execute the query and read the data.
            SqlDataReader reader = command.ExecuteReader();

            // Create a list to hold products.
            List<Product> products = new List<Product>();

            // Read the data and fill the list.
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }

            // Close the database connection.
            _connection.Close();

            // Return the list of products.
            return products;
        }

        // Method that returns all products as DataTable.
        public DataTable Getall2()
        {
            // Check and open the database connection.
            ConnectionControl();

            // Create a SQL query.
            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);

            // Execute the query and read the data.
            SqlDataReader reader = command.ExecuteReader();

            // Create a DataTable to hold the data.
            DataTable dataTable = new DataTable();

            // Load the data into the DataTable.
            dataTable.Load(reader);

            // Close the reader and the database connection.
            reader.Close();
            _connection.Close();

            // Return the DataTable.
            return dataTable;
        }

        // Method for adding a new product.
        public void Add(Product product)
        {
            // Check and open the database connection.
            ConnectionControl();

            // Create a SQL query and add parameters.
            SqlCommand command = new SqlCommand(
                "INSERT INTO Products VALUES (@Name, @UnitPrice, @StockAmount)", _connection);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);

            // Execute the query.
            command.ExecuteNonQuery();

            // Close the database connection.
            _connection.Close();
        }

        // Method for updating an existing product.
        public void Update(Product product)
        {
            // Check and open the database connection.
            ConnectionControl();

            // Create a SQL query and add parameters.
            SqlCommand command = new SqlCommand(
                "UPDATE Products SET Name = @Name, UnitPrice = @UnitPrice, StockAmount = @StockAmount WHERE Id = @Id", _connection);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@Id", product.Id);

            // Execute the query.
            command.ExecuteNonQuery();

            // Close the database connection.
            _connection.Close();
        }

        // Helper method for checking and controlling the database connection.
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
    }
}
