using GameMarketingSimulation.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingSimulation.Abstract
{
    public interface IGameServiceManager
    {
        void Add(Game game );
        void Delete(Game game);
        void Update(Game game);
    }
}
