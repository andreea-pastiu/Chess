using Chess.Models.Pieces;

namespace Chess.Models
{
    public class Player
    {
        public int Id { get; set; }
        public List<ChessPiece> Pieces { get; set; }

        public Player(int id, PieceColor pieceColor)
        {
            this.Id = id;
            this.Pieces = new List<ChessPiece>
            {
                new Rook(pieceColor == PieceColor.White ? 0 : 16, 0, pieceColor == PieceColor.White ? 0 : 7, pieceColor),
                new Knight(pieceColor == PieceColor.White ? 1 : 17, 1, pieceColor == PieceColor.White ? 0 : 7, pieceColor),
                new Bishop(pieceColor == PieceColor.White ? 2 : 18, 2, pieceColor == PieceColor.White ? 0 : 7, pieceColor),
                new Queen(pieceColor == PieceColor.White ? 3 : 19, 3, pieceColor == PieceColor.White ? 0 : 7, pieceColor),
                new King(pieceColor == PieceColor.White ? 4 : 20, 4, pieceColor == PieceColor.White ? 0 : 7, pieceColor),
                new Bishop(pieceColor == PieceColor.White ? 5 : 21, 5, pieceColor == PieceColor.White ? 0 : 7, pieceColor),
                new Knight(pieceColor == PieceColor.White ? 6 : 22, 6, pieceColor == PieceColor.White ? 0 : 7, pieceColor),
                new Rook(pieceColor == PieceColor.White ? 7 : 23, 7, pieceColor == PieceColor.White ? 0 : 7, pieceColor),
                new Pawn(pieceColor == PieceColor.White ? 8 : 24, 0, pieceColor == PieceColor.White ? 1 : 6, pieceColor),
                new Pawn(pieceColor == PieceColor.White ? 9 : 25, 1, pieceColor == PieceColor.White ? 1 : 6, pieceColor),
                new Pawn(pieceColor == PieceColor.White ? 10 : 26, 2, pieceColor == PieceColor.White ? 1 : 6, pieceColor),
                new Pawn(pieceColor == PieceColor.White ? 11 : 27, 3, pieceColor == PieceColor.White ? 1 : 6, pieceColor),
                new Pawn(pieceColor == PieceColor.White ? 12 : 28, 4, pieceColor == PieceColor.White ? 1 : 6, pieceColor),
                new Pawn(pieceColor == PieceColor.White ? 13 : 29, 5, pieceColor == PieceColor.White ? 1 : 6, pieceColor),
                new Pawn(pieceColor == PieceColor.White ? 14 : 30, 6, pieceColor == PieceColor.White ? 1 : 6, pieceColor),
                new Pawn(pieceColor == PieceColor.White ? 15 : 31, 7, pieceColor == PieceColor.White ? 1 : 6, pieceColor),
            };
        }
    }
}
