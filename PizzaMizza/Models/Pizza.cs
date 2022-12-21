using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Models
{
    internal class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }

        static string connectionString = "Server=CA-R215-PC12\\SQLEXPRESS;Database=Pizza;Trusted_Connection = True;Integrated Security = True";

        static SqlConnection _connection;

        public static SqlConnection Conecction
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(connectionString);
                }
                return _connection;
            }
        }

        public static void ExeCommand(string command)
        {

            Conecction.Open();

            using (SqlCommand cmd = new SqlCommand(command, Conecction))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public static void ExeQuery(string query)
        {
            DataTable dataTable= new DataTable();
            Conecction.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Conecction))
            {
                adapter.Fill(dataTable);
            }
            Conecction.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row["Id"]}. {row["Name"]}");
            }
        } 



    }
}
