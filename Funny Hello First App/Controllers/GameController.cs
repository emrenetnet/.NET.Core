using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FunnyHello.Data;

namespace FunnyHello.Controllers
{
    
    public class GameController:Controller
    {
        private readonly IGameRepository _gameRepository;
        public GameController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }
        public IActionResult Index()
        {
            //GameRepository gameRepository = new GameRepository(); /*Tightly-Coupled Line (birbirine sıkı sıkıya bağlı)*/
            var games = _gameRepository.GetAllGames();
            return View(games);
        }
    }
}
