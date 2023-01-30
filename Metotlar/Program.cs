using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
     class Program
    {
        static void Main(string[] args)
        {


            Urun urun1= new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyat = 15.5;
            urun1.Acıklama = "Amasya";

            Urun urun2 = new Urun();
            urun2.Id = 1;
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Acıklama = "Diyarbakır";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            /// type safe   ----- tip güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("-------");

            }
            Console.WriteLine("-------------Metotlar----------\n");
            SepetManager sepetManager= new SepetManager();
            ////Encapsulation
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut","Yeşil",22,10);
            sepetManager.Ekle2("Karpuz", "Kırmızı", 11,5);
            sepetManager.Ekle2("Elma", "Yeşil", 82,3);





            Console.ReadLine();
        }
    }
}
