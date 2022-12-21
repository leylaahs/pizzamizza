using PizzaMizza.Models;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace PizzaMizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string connectionString = "Server=CA-R215-PC12\\SQLEXPRESS,Database=Pizza,Trusted_conection=true";
            ////SqlConnection connection = new SqlConnection(connectionString);
            ////connection.Open();
            ////connection.Close();
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand("INSERT INTO Students VALUES", connection)
            //    {
            //        Console.WriteLine(command.ExecuteScalar());
            //    command.ExecuteScalar();
            //}

            //string variable = "Insert Into Pizzas values ('Vegeterian')";
            //Pizza.ExeCommand(variable);

            string value = "Select * from pizzas";
            Pizza.ExeQuery(value);
        }


    }
    }
