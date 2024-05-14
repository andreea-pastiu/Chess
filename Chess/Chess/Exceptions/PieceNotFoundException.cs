namespace Chess.Exceptions
{
    public class PieceNotFoundException: Exception
    {
        public PieceNotFoundException(string message) : base(message)
        {
        }
    }
}
