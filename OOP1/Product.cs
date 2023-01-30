using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
      class Product
    {///snippet prop şeklindeki yapılar tap tap la gelenler
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD operasyonları ekleme güncelleme gibi classlaradenir
    }
}
