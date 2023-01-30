using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Urun
    { ///proparty'ler -----özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyat { get; set; }
        public string Acıklama { get; set; }
        public int StokAdedi { get; set; }
    }
}
