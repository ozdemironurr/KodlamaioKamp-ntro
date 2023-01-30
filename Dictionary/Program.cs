using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

       

            List<string> list = new List<string>();
            list.Add("Yaban");
            list.Add("Ot");
            list.Add("Zar Adam");
            list.Add("Esir Şehrin İnsanları");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            


            MyDictionary<string> kitaplar = new MyDictionary<string>();

            kitaplar.Add("Yaban");
            kitaplar.Add("Ot");
            kitaplar.Add("Zar Adam");
            kitaplar.Add("Esir Şehrin İnsanları");

            Console.WriteLine("*************");
            Console.WriteLine(kitaplar.Length);

             foreach (var kitap in kitaplar.Items)
            {
                Console.WriteLine(kitap);
            }
           
            Console.ReadLine();



        }
    }
}
