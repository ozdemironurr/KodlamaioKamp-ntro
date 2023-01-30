using GameMarketingSimulation.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingSimulation.Abstract
{
    public interface ICampaignServiceManager
    {
        void Add(Campaign campaing, Game game);
        void Delete( Campaign campaing,Game game);
        void Update( Campaign campaing,Game game);
        
    }
}
