using Chess.DTOs.Responses;
using Chess.Exceptions;
using Chess.Models;
using Chess.Models.Pieces;
using Chess.NewFolder;

namespace Chess.Services
{
    public class GameService
    {
        private readonly PlayerService playerService;
        private readonly GameMapper gameMapper;

        public GameService(PlayerService playerService,
            GameMapper gameMapper)
        {
            this.playerService = playerService;
            this.gameMapper = gameMapper;
        }

        public GameDTO CreateGame(int player1Id, int player2Id)
        {
            if(player1Id == player2Id)
            {
                throw new Exception("Player Ids must be different");
            }
            Player player1 = new Player(player1Id, PieceColor.White);
            Player player2 = new Player(player2Id, PieceColor.Black);
            Game game = new Game
            {
                Id = Guid.NewGuid(),
                Player1 = player1,
                Player2 = player2,
                Turn = PieceColor.Black
            };
            DataStore.Games.Add(game);
            return gameMapper.MapGameToDTO(game);
        }

        private ChessPiece GetPiece(Player player, int x, int y)
        {
            var piece = player.Pieces.FirstOrDefault(piece => piece.X == x && piece.Y == y);
            if(piece == null)
            {
                throw new PieceNotFoundException($"Piece not found at position {x}, {y}");
            }
            return piece;
        }

        public Game GetGameById(Guid gameId)
        {
            var game = DataStore.Games.FirstOrDefault(x => x.Id == gameId);
            if(game == null)
            {
                throw new GameNotFoundException($"Game with Id {gameId} was not found");
            }
            return game;
        }

        public GameDTO MovePiece(Guid gameId, int playerId, int pieceX, int pieceY, int newX, int newY)
        {
            var game = GetGameById(gameId);
            var player = playerService.GetPlayerById(game, playerId);
            var opponent = playerService.GetOpponentById(game, playerId);
            var piece = GetPiece(player, pieceX, pieceY);
            piece.Move(newX, newY, player.Pieces, opponent.Pieces);
            return gameMapper.MapGameToDTO(game);
        }
    }
}
