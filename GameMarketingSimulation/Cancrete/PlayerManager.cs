using GameMarketingSimulation.Abstract;
using GameMarketingSimulation.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingSimulation.Cancrete
{

    public class PlayerManager : IPlayerServiceManager
    {
        private IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                Console.WriteLine("The user named " + player.FirstName + " has been added.");
            }
            else
            {
                throw new Exception("Not a valid person");
            }

        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " player deleted");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " player updated");
        }
    }
}
