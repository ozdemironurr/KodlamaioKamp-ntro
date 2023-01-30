namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  InterfacesIntro();
            //CustomerManager customerManager= new CustomerManager();
            // customerManager.Add(new OracleCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[] { new SqlServerCustomerDal(),new OracleCustomerDal(),new MySqlCustomerDal()};
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }


            Console.ReadLine();
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "DEMİROĞ", Address = "Ankara" });
            Student student = new Student
            {
                Id = 2,
                FirstName = "Onur",
                LastName = "ÖZDEMİR",
                Departmant = "Math"
            };

            personManager.Add(student);
        }
    }
    interface IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class Worker:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }

    }
    class PersonManager
    {
        public void Add(IPerson person )
        {
            Console.WriteLine(person.FirstName + " Eklendi");
        }
    }
}