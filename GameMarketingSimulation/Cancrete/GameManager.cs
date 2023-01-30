using GameMarketingSimulation.Abstract;
using GameMarketingSimulation.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingSimulation.Cancrete
{
    public class GameManager :IGameServiceManager
    {
        public void Add(Game game )
        {
            Console.WriteLine(game.GameName +" game added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " game deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " game updated");
        }
    }
}
