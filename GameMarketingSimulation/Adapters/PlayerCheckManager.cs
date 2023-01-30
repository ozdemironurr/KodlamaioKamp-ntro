using GameMarketingSimulation.Abstract;
using GameMarketingSimulation.Enitities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingSimulation.Adapters
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
           
            return true;
        }
    }
}
