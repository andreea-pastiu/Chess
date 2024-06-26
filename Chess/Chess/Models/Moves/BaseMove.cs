﻿using Chess.Models.Pieces;

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
            bool isValid = false;
            foreach (int multiplier in this.AllowedMultipliers)
            {
                int checkedX = piece.X + (this.XMove * multiplier);
                int checkedY = piece.Y + (this.YMove * multiplier);
                if (checkedX < 0 || checkedX > 7 || checkedY < 0 || checkedY > 7)
                {
                    return false;
                }
                if (checkedX != newX || checkedY != newY)
                {
                    // check that no piece is blocking the move
                    if (myPieces.Any(x => x.X == checkedX && x.Y == checkedY)
                        || opponentPieces.Any(x => x.X == checkedX && x.Y == checkedY))
                    {
                        return false;
                    }
                }
                else
                {
                    //check that no player piece already occupies the position
                    if (myPieces.Any(x => x.X == checkedX && x.Y == checkedY))
                    {
                        return false;
                    }
                    else
                    {
                        var existingOpponent = opponentPieces.Any(x => x.X == checkedX && x.Y == checkedY);
                        if (MustCapture && !existingOpponent)
                        {
                            return false;
                        }
                        return true;
                    }
                }
            }

            return isValid;
        }
    }
}
