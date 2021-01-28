using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) {

            product.ProductName = "Kamera";
            Console.WriteLine("urun sepete eklendi"+product.ProductName);
        }
    }
}
