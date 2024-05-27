using Chess.Models.Moves;

namespace Chess.Models.Pieces
{
    public class King: ChessPiece
    {
        public King(int id, int x, int y, PieceColor color): base(id, x, y, color)
        {
            this.Letter = "K";
            this.AllowedMoves = new List<BaseMove>
            {
                new BaseMove
                {
                    XMove = 1,
                    YMove = 1,
                    AllowedMultipliers = new List<int>{1},
                    MustCapture = false
                },
                new BaseMove
                {
                    XMove = 1,
                    YMove = 1,
                    AllowedMultipliers = new List<int>{-1},
                    MustCapture = false
                },
                new BaseMove
                {
                    XMove = 1,
                    YMove = -1,
                    AllowedMultipliers = new List<int>{1},
                    MustCapture = false
                },
                new BaseMove
                {
                    XMove = 1,
                    YMove = -1,
                    AllowedMultipliers = new List<int>{-1},
                    MustCapture = false
                },
                new BaseMove
                {
                    XMove = 1,
                    YMove = 0,
                    AllowedMultipliers = new List<int>{1},
                    MustCapture = false
                },
                new BaseMove
                {
                    XMove = 1,
                    YMove = 0,
                    AllowedMultipliers = new List<int>{-1},
                    MustCapture = false
                },
                new BaseMove
                {
                    XMove = 0,
                    YMove = 1,
                    AllowedMultipliers = new List<int>{1},
                    MustCapture = false
                },
                new BaseMove
                {
                    XMove = 0,
                    YMove = 1,
                    AllowedMultipliers = new List<int>{-1},
                    MustCapture = false
                },
            };
        }
    }
}
