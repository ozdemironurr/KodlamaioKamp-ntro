using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();


            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            

            Customer customer1=new Customer { FirstName="Engin",Id=1,LastName="DEMİROĞ",City="Ankara"};
            Customer customer2 = new Customer();
            customer2.FirstName = "Derin";
            customer2.Id = 2;
            customer2.LastName = "DEMİROĞ";
            customer2.City = "İstanbul";

            Console.WriteLine(customer2.FirstName);



        }
    }
}
