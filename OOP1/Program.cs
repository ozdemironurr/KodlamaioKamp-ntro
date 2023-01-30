using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1= new Product(); 
            product1.Id= 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            Product product2 = new Product 
            { 
                Id = 1,
                CategoryId = 5, 
                ProductName = "Masa", 
                UnitPrice = 35,
                UnitsInStock = 5 
            };
            //// PascalCase  /// camelCase
            ///case sensitive (Küçük Büyük harf duyarlılığı)
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);



        }
    }
}
