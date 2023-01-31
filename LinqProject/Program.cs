using System.Net.Http.Headers;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category> {
            new Category { CategoryId =1,CategoryName="Bilgisayar"},
            new Category { CategoryId =2,CategoryName="Telefon"}
                        };
            List<Product> products = new List<Product> {
            new Product{ ProductId = 1,CategoryId=1,ProductName ="Acer Laptop",QuentityPerUnit ="32gb Ram",UnitsInStock =5,UnitPrice =10000},
            new Product{ ProductId = 1,CategoryId=1,ProductName ="Asus Laptop",QuentityPerUnit ="16gb Ram",UnitsInStock =3,UnitPrice =8000},
            new Product{ ProductId = 1,CategoryId=1,ProductName ="Hp Laptop",QuentityPerUnit ="8gb Ram",UnitsInStock =2,UnitPrice =6000},
            new Product{ ProductId = 1,CategoryId=2,ProductName ="Samsung Telefon",QuentityPerUnit ="4 gb Ram",UnitsInStock =15,UnitPrice =5000},
            new Product{ ProductId = 1,CategoryId=2,ProductName ="Apple Telefon",QuentityPerUnit ="4gb Ram",UnitsInStock =0,UnitPrice =8000},
            };



            Console.WriteLine("Linq-----------");


          //  GetProductsLinq(products);
            Console.WriteLine("Algoritmik-----------");

           // GetProducts(products);
            Console.ReadLine();
        }

        static List<Product> GetProducts(List<Product> products)
        {      ///Linq olmasa yapılacaklar

            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;

        }
        static List<Product> GetProductsLinq(List<Product> products)
        {      //Linq Kullanımında

            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
        }

    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuentityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}