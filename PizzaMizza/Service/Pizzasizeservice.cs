using PizzaMizza.Helper;
using PizzaMizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Service
{
    internal class Pizzasizeservice: IService<Size>
    {
        public void Add(Size model) => Sql.ExecCommand($"(INSERT INTO Pizzas VALUES{model.Size})");
    }
    public void Delete()
}
