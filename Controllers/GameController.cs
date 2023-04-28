using Microsoft.AspNetCore.Mvc;
using TicTacToeAPI.GameLogic;

namespace TicTacToeAPI.Controllers
{
    [ApiController]
    [Route("api/game")]
    public class GameController : ControllerBase
    {
        private readonly TicTacToeGame _game;

        public GameController(TicTacToeGame game)
        {
            _game = game;
        }

        [HttpGet("board")]
        public ActionResult<string[][]> GetBoard()
        {
            return Ok(_game.GetBoard());
        }

        [HttpGet("currentPlayer")]
        public ActionResult<Player> GetCurrentPlayer()
        {
            return Ok(_game.GetCurrentPlayer());
        }

        [HttpPost("makeMove")]
        public ActionResult<bool> MakeMove(int row, int column)
        {
            //handling the excpetion(wrong move)
            if (row < 0 || row > 2 || column < 0 || column > 2 || _game.GetBoard()[row][column] != "")
            {
                return BadRequest("Invalid move");
            }

            try
            {
                return Ok(_game.MakeMove(row, column));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("isGameOver")]
        public ActionResult<bool> IsGameOver()
        {
            return Ok(_game.IsGameOver());
        }

        [HttpGet("isBoardFull")]
        public ActionResult<bool> IsBoardFull()
        {
            return Ok(_game.IsBoardFull());
        }

        [HttpGet("getWinner")]
        public ActionResult<Player?> GetWinner()
        {
            return Ok(_game.GetWinner());
        }
    }
}
