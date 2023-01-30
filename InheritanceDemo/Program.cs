namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons=new Person[] { 
                new Person { FirstName="Engin"},
                new Student {FirstName="Onur" },
                new Customer { FirstName="Derin"} 
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            

            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string City { get; set; }

    }
    class Student:Person
    {
        public string Depatmant { get; set; }
    }
}