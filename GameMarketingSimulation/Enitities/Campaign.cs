using GameMarketingSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingSimulation.Enitities
{
    public class Campaign: IEntity
    {
        public int Id { get; set; }
        public string CampignName { get; set; }
        public string GameName { get; set; }        
        public string GameVersion { get; set; }
        public string GameCategory { get; set; }
        public double DiscountRate { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
