﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
     class SepetManager
    {///syntax Yazım şekilleri
        public void Ekle(Urun  urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! "+urun.Adi );
        
        }
        public void Ekle2(string urunAdi,string urunAcıklama,double urunFiyat,int urunAdeti) 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! " + urunAdi);

        }



    }
}
