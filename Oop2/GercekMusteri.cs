using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{     ///Individual= Bireysel Müşteri
     class GercekMusteri:Musteri   //Miras Inheritance
    {
       
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
