using GameMarketingSimulation.Abstract;
using GameMarketingSimulation.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingSimulation.Cancrete
{
    public class SalesManager:ISalesServiceManager
    {
        

        public void AddSales(Player player, Game game, Campaign campaign=null)
        {
            if (campaign == null)
            {
                Console.WriteLine(game.GameName+" game purchased without promotion.");
            }
            else
            {
                Console.WriteLine( " You bought the "+game.GameName+" game with the "+campaign.CampignName+" campaign");
            }
        }

        public void DeleteSales(Player player, Game game=null, Campaign campaing=null)
        {
            Console.WriteLine("The purchase has been deleted.");
        }

       
    }
}
