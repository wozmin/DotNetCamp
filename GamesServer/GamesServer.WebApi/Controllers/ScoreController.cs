using System;
using GamesServer.BLL.DTO;
using GamesServer.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GamesServer.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/score")]
    public class ScoreController : Controller
    {
        private readonly IGameService _gameService;
        private readonly IScoreService _scoreService;
        public ScoreController(IGameService gameService,IScoreService scoreService)
        {
            _gameService = gameService;
            _scoreService = scoreService;
        }

        [HttpPost]
        public IActionResult SaveScore (Guid gameId,Guid userId)
        {
            if (!_gameService.isGameExists(gameId))
            {
                return BadRequest();
            }
            _scoreService.SaveScore(new SaveScoreDTO{GameId = gameId,UserId = userId});
            return Ok();
        }

        [HttpGet("game/{gameId}")]
        public IActionResult GetScoresByGame(Guid gameId)
        {
            if (!_gameService.isGameExists(gameId))
            {
                return BadRequest("Game is not exists");
            }

            return Ok(_scoreService.GetScoresByGame(gameId));
        }

        [HttpGet("user/{userId}")]
        public IActionResult GetScoresByUser(string userId)
        {
            return Ok(_scoreService.GetScoresByUser(userId));
        }

    }
}