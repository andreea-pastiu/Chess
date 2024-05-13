using Chess.Models.Pieces;

namespace Chess.Models.Moves
{
    public class BaseMove
    {
        public int XMove { get; set; }
        public int YMove { get; set; }
        public List<int> AllowedMultipliers { get; set; }
        public bool MustCapture { get; set; }

        public virtual bool IsValid(
            ChessPiece piece, 
            int newX, 
            int newY, 
            List<ChessPiece> myPieces, 
            List<ChessPiece> opponentPieces)
        {
            bool isValid = true;
            foreach (int multiplier in this.AllowedMultipliers)
            {
                int checkedX = piece.X + (this.XMove * multiplier);
                int checkedY = piece.Y + (this.YMove * multiplier);
                if (checkedX < 0 || checkedX > 7 || checkedY < 0 || checkedY > 7)
                {
                    continue;
                }
                if(checkedX != newX && checkedY != newY)
                {
                    // check that no piece is blocking the move
                    if(myPieces.Any(x => x.Id != piece.Id && x.X == checkedX && x.Y == checkedY)
                        || opponentPieces.Any(x => x.X == checkedX && x.Y == checkedY))
                    {
                        isValid = false;
                    }
                }
                else
                {
                    //check that no player piece already occupies the position
                    if (myPieces.Any(x => x.Id != piece.Id && x.X == checkedX && x.Y == checkedY))
                    {
                        isValid = false;
                        break;
                    }
                    else
                    {
                        var existingOpponent = opponentPieces.FirstOrDefault(x => x.X == checkedX && x.Y == checkedY);
                        if(MustCapture && existingOpponent == null)
                        {
                            isValid = false;
                            break;
                        }
                        if(existingOpponent != null)
                        {
                            opponentPieces.Remove(existingOpponent);
                        }
                    }
                }
            }

            return isValid;
        }
    }
}
