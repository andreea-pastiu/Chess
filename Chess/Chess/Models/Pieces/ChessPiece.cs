using Chess.Exceptions;
using Chess.Models.Moves;

namespace Chess.Models.Pieces
{
    public abstract class ChessPiece
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string Letter { get; set; }
        public PieceColor Color { get; set; }
        public List<BaseMove> AllowedMoves { get; set; }

        protected ChessPiece(int id, int x, int y, PieceColor color)
        {
            Id = id;
            X = x;
            Y = y;
            Color = color;
        }

        public bool Move(int newX,
            int newY,
            List<ChessPiece> myPieces,
            List<ChessPiece> opponentPieces)
        {
            var allowedMove = this.AllowedMoves.Any(x => x.IsValid(this, newX, newY, myPieces, opponentPieces));
            if(allowedMove)
            {
                throw new MoveNotAllowedException("Illegal move");
            }
            else
            {
                var existingOpponent = opponentPieces.FirstOrDefault(x => x.X == newX && x.Y == newY);
                if(existingOpponent != null)
                {
                    opponentPieces.Remove(existingOpponent);
                }
                this.X = newX;
                this.Y = newY;
                return true;
            }
        }

        public bool CheckSituation(King king, 
            List<ChessPiece> myPieces,
            List<ChessPiece> opponentPieces)
        {
            return this.AllowedMoves.Any(x => x.IsValid(this, king.X, king.Y, myPieces, opponentPieces));
        }
    }
}
