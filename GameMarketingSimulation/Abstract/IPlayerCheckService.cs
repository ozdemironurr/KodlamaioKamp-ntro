using GameMarketingSimulation.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingSimulation.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPerson(Player player);
    }
}
