namespace Oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {//SOLID yazılım geliştirme prensibleri

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "DEMİROĞ";
            musteri1.TcNo = "222222";

            //// Kodlomaio

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlamaio";
            musteri2.VergiNo = "12345678952";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            

            MusteriManager musteriManager=  new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);






            Console.ReadLine();
        }
    }
}