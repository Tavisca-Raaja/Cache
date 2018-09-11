using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DesignPatterns
{
    class SqlDataBase:IRepositery
    {
        SqlConnection Connection;
        SqlConnectionStringBuilder Connector;
        public SqlDataBase()
        {
            
            try
            {
                Connector = new SqlConnectionStringBuilder();
                Connector.DataSource = "localhost";
                Connector.UserID = "sa";
                Connector.Password = "test123!@#";
                Connector.InitialCatalog = "Product";
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<Product> GetAllDetails()
        {
            List<Product> product = new List<Product>();
            string query = "SELECT * FROM HotelProduct";
            Connection = new SqlConnection(Connector.ToString());
            SqlCommand command = new SqlCommand(query,Connection)
            {
                CommandType = CommandType.Text
            };
            SqlDataAdapter data= new SqlDataAdapter(command);
            DataTable table = new DataTable();
            Connection.Open();
            data.Fill(table);
            Connection.Close();
            foreach (DataRow row in table.Rows)
            {
                product.Add(
                    new Product
                    {
                        Name = Convert.ToString(row["Name"]),
                        Fare = Convert.ToInt32(row["Fare"]),
                        Id=Convert.ToInt32(row["Id"])
                    }
                );

            }
            return product;
        }
    
        
    }
}
