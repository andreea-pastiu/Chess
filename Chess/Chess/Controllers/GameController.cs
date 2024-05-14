using Chess.DTOs.Requests;
using Chess.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chess.Controllers
{
    [Route("api/game")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly GameService gameService;

        public GameController(GameService gameService)
        {
            this.gameService = gameService;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateGameRequest createGameRequest)
        {
            var game = gameService.CreateGame(createGameRequest.Player1Id, createGameRequest.Player2Id);
            return Ok(game);
        }

        [HttpPost("movePiece")]
        public IActionResult MovePiece([FromBody] MovePieceRequest movePieceRequest)
        {
            var game = gameService.MovePiece(movePieceRequest.GameId, movePieceRequest.PlayerId, movePieceRequest.PieceX, movePieceRequest.PieceY, movePieceRequest.NewX, movePieceRequest.NewY);
            return Ok(game);
        }
    }
}
