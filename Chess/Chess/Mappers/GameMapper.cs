using Chess.DTOs.Responses;
using Chess.Models;

namespace Chess.NewFolder
{
    public class GameMapper
    {
        public GameDTO MapGameToDTO(Game game)
        {
            GameDTO gameDTO = new GameDTO();
            gameDTO.Id = game.Id;
            gameDTO.Turn = game.Turn;
            gameDTO.Board = new int[8][]
            {
                new int[8],
                new int[8],
                new int[8],
                new int[8],
                new int[8],
                new int[8],
                new int[8],
                new int[8],
            };
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    gameDTO.Board[i][j] = -1;
                }
            }
            foreach(var piece in game.Player1.Pieces)
            {
                gameDTO.Board[piece.Y][piece.X] = piece.Id;
            }
            foreach (var piece in game.Player2.Pieces)
            {
                gameDTO.Board[piece.Y][piece.X] = piece.Id;
            }
            return gameDTO;
        }
    }
}
