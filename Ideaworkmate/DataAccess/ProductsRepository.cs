﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataAccess
{
   public class ProductsRepository : ConnectionClass
    {
       public IEnumerable<Product> GetAllProducts()
       {
           return Entity.Products.AsEnumerable();
       }
    }
}
