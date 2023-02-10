using System.ComponentModel.DataAnnotations;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            { FirstName = "Onur", LastName = "ÖZDEMİR", Age = 29,Id=2 };
            CustomerDal customerDal= new CustomerDal();
            customerDal.Add(customer);
        }
    }
    [ToTable("Customers")]
    [ToTable("TblCustomers")]//bazı durumlarda 2 tane tablo ismi aramam için gerkli olabilir 
                              // o yüzden AllowMultiple true yapıp 2 ve daha fazla kullanılabilir.
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Methot ")]
        public void Add(Customer customer) 
        { 
            Console.WriteLine("{0}, {1}, {2}, {3} added",customer.Id,customer.FirstName,customer.LastName,customer.Age); 
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }


    }

    [AttributeUsage(AttributeTargets.Property,AllowMultiple =false)]
    class RequiredPropertyAttribute:Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tapleName;

        public ToTableAttribute(string tapleName)
        {
            _tapleName = tapleName;
        }
    }
   

}