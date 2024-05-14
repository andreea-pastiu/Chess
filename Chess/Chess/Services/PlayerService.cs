using Chess.Exceptions;
using Chess.Models;

namespace Chess.Services
{
    public class PlayerService
    {
        public Player GetPlayerById(Game game, int playerId)
        {
            if (game.Player1.Id == playerId)
            {
                return game.Player1;
            }
            if (game.Player2.Id == playerId)
            {
                return game.Player2;
            }
            throw new PlayerNotFoundException($"No player with id {playerId} in game {game.Id}");
        }

        public Player GetOpponentById(Game game, int playerId)
        {
            if (game.Player1.Id == playerId)
            {
                return game.Player2;
            }
            if (game.Player2.Id == playerId)
            {
                return game.Player1;
            }
            throw new PlayerNotFoundException($"No player with id {playerId} in game {game.Id}");
        }
    }
}
