using System.Net.Http.Headers;
using System.Threading.Tasks.Dataflow;

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
            new Product{ ProductId = 2,CategoryId=1,ProductName ="Asus Laptop",QuentityPerUnit ="16gb Ram",UnitsInStock =3,UnitPrice =9000},
            new Product{ ProductId = 3,CategoryId=1,ProductName ="Hp Laptop",QuentityPerUnit ="8gb Ram",UnitsInStock =2,UnitPrice =6000},
            new Product{ ProductId = 4,CategoryId=2,ProductName ="Samsung Telefon",QuentityPerUnit ="4 gb Ram",UnitsInStock =15,UnitPrice =5000},
            new Product{ ProductId = 5,CategoryId=2,ProductName ="Apple Telefon",QuentityPerUnit ="4gb Ram",UnitsInStock =0,UnitPrice =8000},
            };
            // GetProductsLinq(products);
            // GetProducts(products);
            // AnyTest(products); Ürün varmı diye bakar true false değğerleri verir

            // FindTest(products); Ürün Bilgilerine Erişmeye yarar

            // FindAllTest(products);  Aranan helimeleri cümleleri  harflari aramaya yarar liste döner
            // AscDescThenOrderBy(products);

            //                                                                         
            ///ClassicLinq(products); // sql kodu gibi yazma Linq

            var result = from p in products
                         join c in categories on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice ascending, p.ProductName ascending
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var productDto in result)
            {
                Console.WriteLine("Product: {0} Category: {1}", productDto.ProductName, productDto.CategoryName);
            }
            Console.ReadLine();
        }

        private static void ClassicLinq(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice ascending, p.ProductName descending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice }; ///Linq farklı kullanımı


            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDescThenOrderBy(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice).ThenBy(p => p.ProductName);//order by istenilen özelliğegöre sıralar
                                                                                                                                 // decs yoksa asc kullanır
                                                                                                                                 // thenBy=ekstra sıralama koymak için kullanılır.
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result.ToList());
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result);
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
    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }
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