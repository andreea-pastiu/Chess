using Chess.Models.Moves;

namespace Chess.Models.Pieces
{
    public class Rook: ChessPiece
    {
        public Rook(int id, int x, int y, PieceColor color): base(id, x, y, color)
        {
            this.Letter = "R";
            this.AllowedMoves = new List<BaseMove>
            {
                new BaseMove
                {
                    XMove = 1,
                    YMove = 0,
                    AllowedMultipliers = new List<int>{ -7, -6, -5, -4, -3 -2, -1, 1, 2, 3, 4, 5, 6, 7},
                    MustCapture = false
                },
                new BaseMove
                {
                    XMove = 0,
                    YMove = 1,
                    AllowedMultipliers = new List<int>{ -7, -6, -5, -4, -3 -2, -1, 1, 2, 3, 4, 5, 6, 7},
                    MustCapture = false
                },
            };
        }
    }
}
