namespace İnterfacesDemo3
{
    internal class Program
    {/// interfaces new'lenemezler
        static void Main(string[] args)
        {
           // IPersonManager customerManager = new CustomerManager();
           // IPersonManager employeeManager = new EmployeeManager();
            CustomerManager customerManager = new CustomerManager();
            EmployeeManager employeeManager = new EmployeeManager();
            InternManager internManager=    new InternManager();


            customerManager.Add();
            employeeManager.Add();
            employeeManager.Update();
            Console.WriteLine("*******\n");
            ProjectManager projectManager= new ProjectManager();
            projectManager.Add(internManager);




            Console.ReadLine();
        }
    }
    interface IPersonManager
    {
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müsteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müsteri güncellendi.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi.");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        { 
            personManager.Add();
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajer  güncellendi");
        }
    }
}