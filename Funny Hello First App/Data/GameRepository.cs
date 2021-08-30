using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    using FunnyHello.Models;
namespace FunnyHello.Data
{
    public class GameRepository : IGameRepository
    {
        public IEnumerable<Game> GetAllGames()
        {
            return new List<Game>
            {
                new Game{id=1, Title="Commandos II", ListPrice=10.5M },
                new Game{id=2, Title="Prince of Persia",ListPrice=9.45M },
                new Game{id=3, Title="Prince of Persia",ListPrice=9.45M }
            };
        }
    }
}
