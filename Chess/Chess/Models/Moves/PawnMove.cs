using Chess.Models.Pieces;

namespace Chess.Models.Moves
{
    public class PawnMove: BaseMove
    {
        public override bool IsValid(ChessPiece piece, int newX, int newY, List<ChessPiece> myPieces, List<ChessPiece> opponentPieces)
        {
            if(piece.Color == PieceColor.Black)
            {
                this.YMove *= -1;
            }
            return base.IsValid(piece, newX, newY, myPieces, opponentPieces);
        }
    }
}
