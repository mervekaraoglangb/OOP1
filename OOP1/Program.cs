using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product();
            Product1.Id = 1;
            Product1.CategoryId = 2;
            Product1.ProductName = "Masa";
            Product1.UnitPrice = 500;
            Product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock=5,
                ProductName="Kategori",UnitPrice=35};

            ProductManager ProductManager = new ProductManager();
            ProductManager.Add(Product1);


            


        }
    }
}
