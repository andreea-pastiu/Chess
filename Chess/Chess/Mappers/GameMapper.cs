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
            gameDTO.Board = new string[8][]
            {
                new string[8],
                new string[8],
                new string[8],
                new string[8],
                new string[8],
                new string[8],
                new string[8],
                new string[8],
            };
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    gameDTO.Board[i][j] = "-1";
                }
            }
            foreach(var player in game.PlayerList)
            {
                foreach(var piece in player.Pieces)
                {
                    gameDTO.Board[piece.Y][piece.X] = $"{piece.Letter}{piece.Id}";
                }
            }
            return gameDTO;
        }
    }
}
