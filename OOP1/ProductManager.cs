using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName+"Eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+"Güncellendi");
            
        }
        public int topla(int sy1, int sy2)
        {
            return sy1 + sy2;
        }

        public void topla2(int sy1, int sy2)
        {
           Console.WriteLine( sy1 + sy2);
        }
    }
}
