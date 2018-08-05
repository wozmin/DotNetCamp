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
        private readonly IAccountService _accountService;
        private readonly IGameService _gameService;
        private readonly IScoreService _scoreService;
        public ScoreController(IGameService gameService,IScoreService scoreService,IAccountService accountService)
        {
            _gameService = gameService;
            _scoreService = scoreService;
            _accountService = accountService;
        }


        [HttpPost("{gameId}/{userId}")]
        public IActionResult SaveScore (Guid gameId,string userId)
        {
            if (!_gameService.isGameExists(gameId))
            {
                return NotFound("Game not found");
            }

            if (!_accountService.IsUserExists(userId))
            {
                return NotFound($"User with id {userId} not found");
            }
            _scoreService.SaveScore(new SaveScoreDTO{GameId = gameId,UserId = userId});
            return Ok();
        }

        [HttpGet("game/{gameId}")]
        public IActionResult GetScoresByGame(Guid gameId)
        {
            if (!_gameService.isGameExists(gameId))
            {
                return NotFound("Game is not exists");
            }

            return Ok(_scoreService.GetScoresByGame(gameId));
        }

        [HttpGet("user/{userId}")]
        public IActionResult GetScoresByUser(string userId)
        {
            if (!_accountService.IsUserExists(userId))
            {
                return NotFound($"User with id {userId} not found");
            }
            return Ok(_scoreService.GetScoresByUser(userId));
        }

    }
}