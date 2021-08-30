using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunnyHello.Models;


namespace FunnyHello.Data
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetAllGames(); 
    }
}
