﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOne
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "added");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Updated");
        }
    }
}
