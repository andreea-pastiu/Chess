using Chess.Models.Moves;

namespace Chess.Models.Pieces
{
    public class Bishop: ChessPiece
    {
        public Bishop(int id, int x, int y, PieceColor color): base(id, x, y, color)
        {
            this.Letter = "B";
            this.AllowedMoves = new List<BaseMove>
            {
                new BaseMove
                {
                    XMove = 1,
                    YMove = 1,
                    AllowedMultipliers = new List<int>{1, 2, 3, 4, 5, 6, 7},
                    MustCapture = false
                },
                new BaseMove
                {
                    XMove = 1,
                    YMove = 1,
                    AllowedMultipliers = new List<int>{-1, -2, -3, -4, -5, -6, -7},
                    MustCapture = false
                },
                new BaseMove
                {
                    XMove = 1,
                    YMove = -1,
                    AllowedMultipliers = new List<int>{1, 2, 3, 4, 5, 6, 7},
                    MustCapture = false
                },
                new BaseMove
                {
                    XMove = 1,
                    YMove = -1,
                    AllowedMultipliers = new List<int>{-1, -2, -3, -4, -5, -6, -7},
                    MustCapture = false
                }
            };
        }
    }
}
