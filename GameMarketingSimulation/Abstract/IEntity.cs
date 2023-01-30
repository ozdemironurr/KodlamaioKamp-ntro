using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingSimulation.Abstract
{
    public interface IEntity
    {
        public int Id { get; set; } 
        public double DiscountRate { get; set; }
    }
}
