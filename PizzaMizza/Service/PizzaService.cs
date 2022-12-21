using PizzaMizza.Helper;
using PizzaMizza.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Service
{
    internal class PizzaService: IService<Pizza>
    {
        public void Add(Pizza model) => Sql.ExecCommand($"(INSERT INTO Pizzas VALUES{model.Name})");

    }
    public void Delete(int Id)
    {
        Sql.ExecCommand("DELETE Pizza WHERE Id={Id}");
    }
    public List<Pizza> GetAll()
    {
        DataTable dt = Sql.ExecQuery("Select * from Pizza")
            List<Pizza>pizzas= new List<Pizza>();
        foreach (DataRow dr in dt.Rows)
        {
            pizza.Add(new Pizza { Id = Convert.ToInt32(dr["id"]), }),Name = dr["name"].ToString() });
        }
    }
}
