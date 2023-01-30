using GameMarketingSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingSimulation.Enitities
{
    public class Sales : IEntity
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public string CampignName { get ; set ; }
        public double DiscountRate { get; set; }
    }
}
