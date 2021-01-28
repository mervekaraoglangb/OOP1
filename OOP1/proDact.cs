using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet - Hazır kodlar kısaltmalar
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }//product - ürün
        public double UnitPrice { get; set; }//unitprice - birim fiyat
        public int UnitsInStock { get; set; }//unitsInStock - stok adeti
    }
}
