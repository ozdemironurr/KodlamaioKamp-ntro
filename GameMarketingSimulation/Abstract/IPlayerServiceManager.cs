using GameMarketingSimulation.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingSimulation.Abstract
{
    public interface IPlayerServiceManager
    {
        void Add(Player player);
        void Delete(Player player);
        void Update(Player player);
    

    }
}
