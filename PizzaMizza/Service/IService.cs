﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Service
{
   Interface s IService<T>
    {


        void Add(T model);
        List <T>GetAll();
        void Delete(int id);
    }
}
