using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] kurslar = new string[] {"Yazılım Geliştirme Kampı","Programlaya başlangıç için temel kurs","java","C#" };

            //foreach (var kurs in kurslar)
            //{
            //    Console.WriteLine(kurs);
            //}

            string adi = "Engin";
            int yas = 36;


            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmen = "Engin DEMİROG";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JAVA";
            kurs2.KursEgitmen = "Kerem VARİŞ";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.KursEgitmen = "Berkay BİLGİN";
            kurs3.IzlenmeOrani = 84;

            // Console.WriteLine(kurs1.KursAdi+" : "+kurs1.KursEgitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursEgitmen);
            }




            Console.ReadLine();
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
