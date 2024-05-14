using Chess.Exceptions;
using Chess.Models;

namespace Chess.Services
{
    public class PlayerService
    {
        public Player GetPlayerById(Game game, int playerId)
        {
            var player = game.PlayerList.FirstOrDefault(x => x.Id == playerId);
            if (player == null)
            {
                throw new PlayerNotFoundException($"No player with id {playerId} in game {game.Id}");
            }
            else
            {
                return player;
            }
        }

        public Player GetOpponentById(Game game, int playerId)
        {
            var otherPlayers = game.PlayerList.Where(x => x.Id != playerId);
            if(otherPlayers.Count() > 1)
            {
                throw new PlayerNotFoundException($"No player with id {playerId} in game {game.Id}");
            }
            else
            {
                return otherPlayers.First();
            }
        }

        public Player GetCurrentPlayer(Game game)
        {
            return game.PlayerList.First(x => x.Color == game.Turn);
        }
    }
}
