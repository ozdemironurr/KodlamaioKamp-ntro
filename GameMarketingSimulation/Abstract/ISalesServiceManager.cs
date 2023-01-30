using GameMarketingSimulation.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GameMarketingSimulation.Abstract
{
    public interface ISalesServiceManager
    {
        void AddSales(Player player, Game game,Campaign campaign );
        void DeleteSales(Player player ,Game game ,Campaign campaing);
        
    }
}
