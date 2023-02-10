﻿using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DortIslem dortIslem = new DortIslem(2,3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3,6));
            var tip = typeof(DortIslem);
            // DortIslem dortIslem= (DortIslem)Activator.CreateInstance(tip,6,7);
            //Console.WriteLine(dortIslem.Topla(4, 5));
            //Console.WriteLine(dortIslem.Topla2());
           var instance = (DortIslem)Activator.CreateInstance(tip, 6, 5);
           
             MethodInfo methodInfo=instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));
            Console.WriteLine("---------------");
            var metodlar = tip.GetMethods();
            foreach (var info in metodlar)
            {
                Console.WriteLine("Metot adı: {0}",info.Name);
                foreach (var parameters in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}",parameters.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("attribute : {0}", attribute.GetType().Name);
                }
            }
            Console.ReadLine();
        }
    }
    class DortIslem
    {
        private int _sayi1, _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
           _sayi1 = sayi1;
           _sayi2 = sayi2;
        }
        public DortIslem()
        {

        }
        

        public int Topla(int sayi1,int sayi2) 
        {
        return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MethotName("Çarpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

    }
    class MethotNameAttribute:Attribute
    {
        public MethotNameAttribute(string name)
        {

        }
    }
   
}