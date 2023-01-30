namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager esnafKredisiManager =new EsnafKredisiManager();

            ILoggerService databaseLoggerService=new DatabaseLoggerService();
            ILoggerService fileLoggerService=new FileLoggerService(); 
            ILoggerService smsLoggerService=new SmsLoggerService();
            
            List<ILoggerService> loggers= new List<ILoggerService>{new SmsLoggerService(),new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager,loggers);

            Console.WriteLine("********");
            Console.WriteLine("********");
            Console.WriteLine("********");

            basvuruManager.BasvuruYap(esnafKredisiManager,new List<ILoggerService>() { smsLoggerService,databaseLoggerService });

          List<IKrediManager> krediler = new List<IKrediManager> {ihtiyacKrediManager,tasitKrediManager };
          //  basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}