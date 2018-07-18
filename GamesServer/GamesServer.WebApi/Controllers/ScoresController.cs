using System;
using GamesServer.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using GamesServer.BLL.DTO;

namespace GamesServer.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/scores")]
    public class ScoresController : Controller
    {
        private readonly IGameService _gameService;
        private readonly IUserService _userService;
        private readonly IScoresService _scoresService;
        public ScoresController(IScoresService scoresService,IUserService userService,IGameService gameService)
        {
            _scoresService = scoresService;
            _userService = userService;
            _gameService = gameService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_scoresService.GetScores());
        }

        [HttpGet("{id}")]
        public IActionResult ScoresByUser(Guid id)
        {
            if (!_userService.isUserExists(id))
            {
                return NotFound();
            }

            return Ok(_scoresService.GetScoresByUser(id));
        }

        [HttpPost()]
        public IActionResult SaveScores(SaveScoreDTO score)
        {
            if (score == null)
            {
                return BadRequest();
            }

            SaveScores(score);
            return Ok();

        }

        [HttpGet("user/{userId}/game/{gameId}")]
        public IActionResult GetScoreByUserGame(Guid userId, Guid gameId)
        {
            if (!_userService.isUserExists(userId))
            {
                return BadRequest();
            }

            if (!_gameService.isGameExists(gameId))
            {
                return BadRequest();
            } 
            return Ok(_scoresService.GetScoresByGameUser(userId, gameId));
        }
    }
}