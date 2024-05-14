using Chess.Models.Moves;

namespace Chess.Models.Pieces
{
    public class Knight: ChessPiece
    {
        public Knight(int id, int x, int y, PieceColor color): base(id, x, y, color)
        {
            this.Letter = "N";
            this.AllowedMoves = new List<BaseMove>
            {
                new BaseMove
                {
                    XMove = 2,
                    YMove = 1,
                    AllowedMultipliers = new List<int>{ -1, 1},
                    MustCapture = false
                },
                new BaseMove
                {
                    XMove = -2,
                    YMove = 1,
                    AllowedMultipliers = new List<int>{ -1, 1},
                    MustCapture = false
                },
                new BaseMove
                {
                    XMove = 1,
                    YMove = 2,
                    AllowedMultipliers = new List<int>{ -1, 1},
                    MustCapture = false
                },
                new BaseMove
                {
                    XMove = -1,
                    YMove = 2,
                    AllowedMultipliers = new List<int>{ -1, 1},
                    MustCapture = false
                },
            };
        }
    }
}
