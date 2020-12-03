using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MenuItemRepository
    {
        public List<MenuItem> GetAllMenuItems()
        {
            List<MenuItem> list = new List<MenuItem>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM MenuItems;";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.NextResult())
                {
                    int id = sqlDataReader.GetInt32(0);
                    string title = sqlDataReader.GetString(1);
                    string description = sqlDataReader.GetString(2);
                    decimal price = sqlDataReader.GetDecimal(3);

                    MenuItem mi = new MenuItem(id, title, description, price);

                    list.Add(mi);
                }
                return list;

            }

        }
        public int InsertMenuItem(MenuItem x)
        {
            using (SqlConnection sqlConnection=new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO MenuItems VALUES ('{0}', '{1}', {2})", x.Title, x.Description, x.Price);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
