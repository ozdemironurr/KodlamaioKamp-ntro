namespace AbstractClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AMevzuat aMevzuat=new AMevzuat();
            //aMevzuat.Kaydet();
            //aMevzuat.Degerlendir();

            CMevzuat cMevzuat= new CMevzuat();
            cMevzuat.Sil();

           Console.ReadLine();
        }
    }
    abstract class MevzuatBase
    {
        protected MevzuatBase()    //sadece inheritance edildiği yerde çalışırlar için PROTECTED
        {

        }
       public abstract void Degerlendir(); /// alt sınıflar zorunlu tutar kendilerine güzenleme yapabilir "override"
        public void Kaydet()
        {
            Console.WriteLine("Kaydedildi.");      
        }
        public virtual void Sil()    /// bu operasyonu alt sınıflar kullanabilir isterlerse ezip kendileri düzenliyebilir
        {
            Console.WriteLine("Kaydedildi.");
        }
    }
    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A Mevzuatına göre değerlendirildi.");
        }
    }
    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B Mevzuatına göre değerlendirildi.");
        }
    }
    class CMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("C Mevzuatına göre değerlendirildi.");
        }
        public virtual void Sil() 
        {
            Console.WriteLine("C Mevzuatını silindi.");    // Abstracta olab virtual operasyonunu değiştirip kullana biliriz
            base.Sil();                                   // yada base diyerek abstarctaki operastonu olduğu gibi kullanabiliriz
        }

    }
    class CustomerManager
    {
        public void Add() 
        {
            Console.WriteLine("Added");
        }
        public void Delete() 
        {
            Console.WriteLine("Deleted");
        }
    }
    class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}