using GameMarketingSimulation.Abstract;
using GameMarketingSimulation.Adapters;
using GameMarketingSimulation.Cancrete;
using GameMarketingSimulation.Enitities;

namespace GameMarketingSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Game game1 = new Game()
            {
                Id = 12,
                GameName = "Knight",
                GameCategory = "Online",
                CampignName = "Black Friday",
                DiscountRate = 0.15,
                GameVersion = "12.01.02"
            };

            Campaign campaing1 = new Campaign()
            {
                Id = 2,
                CampignName = "Black Friday",
                GameName = "Knight",
                GameCategory = "Online",
                DiscountRate = 0.15,
                GameVersion = "12.01.02",
                StartingDate = new DateTime(23, 03, 05),
                ExpirationDate = new DateTime(2024, 01, 01),
            };
            Player player1 = new Player()
            {
                Id = 1,
                FirstName = "Onur",
                LastName = "ÖZDEMİR",
                DateOfBirth = new DateTime(1994, 01, 01),
                NationalityId = "2521232121",
                DiscountRate = 0.15
            };

            PlayerManager playerManager=new PlayerManager(new MernisServiceAdapter());
            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();
            SalesManager selesManager = new SalesManager();

            selesManager.AddSales(player1, game1, campaing1);
            selesManager.AddSales(player1, game1);
            selesManager.DeleteSales(player1);
            Console.WriteLine("**************\n");


            playerManager.Add(player1);
            playerManager.Delete(player1);
            playerManager.Update(player1);

            Console.WriteLine("**************\n");

            gameManager.Add(game1);
            gameManager.Delete(game1);
            gameManager.Update(game1);

            Console.WriteLine("**************\n");

            campaignManager.Add(campaing1, game1);
            campaignManager.Add(campaing1);

        }
    }
}