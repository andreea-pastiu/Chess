using Chess.Models.Moves;

namespace Chess.Models.Pieces
{
    public class Pawn: ChessPiece
    {
        public Pawn(int id, int x, int y, PieceColor color): base(id, x, y, color)
        {
            this.Letter = "P";
            this.AllowedMoves = new List<BaseMove>
            {
                new PawnMove
                {
                    XMove = 0,
                    YMove = 1,
                    AllowedMultipliers = new List<int>{ 1 },
                    MustCapture = false
                },
                new PawnMove
                {
                    XMove = 1,
                    YMove = 1,
                    AllowedMultipliers = new List<int>{ 1 },
                    MustCapture = true
                },
                new PawnMove
                {
                    XMove = -1,
                    YMove = 1,
                    AllowedMultipliers = new List<int>{ 1 },
                    MustCapture = true
                }
            };
        }
    }
}
