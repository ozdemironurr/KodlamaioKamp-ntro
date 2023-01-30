using GameMarketingSimulation.Abstract;
using GameMarketingSimulation.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingSimulation.Cancrete
{
    public class CampaignManager : ICampaignServiceManager
    {
        ////////////////////////////***************************     ADD       ***********************************//////////////////////////

       

        public void Add(Campaign campaign, Game game = null)
        {
            if (game == null)
            {
                Console.WriteLine(campaign.CampignName + " campaign successfully added");
            }
            else 
            {
                Console.WriteLine(campaign.CampignName + " campaign successfully added for " + game.GameName);
            }

        }



        ////////////////////////////***************************     DELETE       ***********************************//////////////////////////


        public void Delete(Campaign campaign, Game game = null)
        {
            if (game == null)
            {
                Console.WriteLine(campaign.CampignName + " campaign deletion has been successfully.");
            }
            else 
            {
                Console.WriteLine("The" + campaign.CampignName + " campaign in the game " + game.GameName + " has been successfully deleted.");
            }


        }
        ////////////////////////////***************************     UPDATE   *************************//////////////////////////
        public void Update(Campaign campaign, Game game=null)
        {

            if (game == null)
            {
                Console.WriteLine(campaign.CampignName + " campaign updated");
            }
            else
            {
                Console.WriteLine("The campaign in the game " + game.GameName + " has been updated");
            }

        }

    }




}
