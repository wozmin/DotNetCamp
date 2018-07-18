using GamesServer.BLL.DTO;
using GamesServer.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GamesServer.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/games")]
    public class GameController : Controller
    {
        private readonly IGameService _gameService;
        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }
        [HttpGet(Name = "GetGames")]
        public IActionResult GetGames()
        {
            return Ok(_gameService.getGames());
        }
        //0506768765
        [HttpPost]
        public IActionResult AddGame([FromBody] CreateGameDTO game)
        {
            if (game == null)
            {
                return BadRequest();
            }
            //_gameService.AddGame(game);
            return Ok(game);
        }
    }
}