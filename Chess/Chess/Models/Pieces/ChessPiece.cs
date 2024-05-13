using Chess.Models.Moves;

namespace Chess.Models.Pieces
{
    public abstract class ChessPiece
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
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
            foreach(var move in AllowedMoves)
            {
                if(move.IsValid(this, newX, newY, myPieces, opponentPieces))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
