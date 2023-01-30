namespace InterfacesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[]
            {
                new Worker(),
                new Manager(),
                new Robots() 
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats=new IEat[] {new Worker(),new Manager()};
            foreach (var eat in eats)
            {
                eat.Eat();
            }


            Console.ReadLine();
        }
    }
    interface IWorker
    {
        void Work();

    }
    interface IEat
    {
        void Eat();
    }
    interface ISalaty
    {
        void GetSalaty();
    }


    class Manager : IWorker, IEat, ISalaty
    {
        public void Eat()
        {
          
        }

        public void GetSalaty()
        {
           
        }

        public void Work()
        {
           
        }
    }
    class Worker : IWorker, ISalaty, IEat
    {
        public void Eat()
        {
           
        }

        public void GetSalaty()
        {
           
        }

        public void Work()
        {
          
        }
    }
    class Robots : IWorker
    {
        public void Work()
        {

        }
    }
}