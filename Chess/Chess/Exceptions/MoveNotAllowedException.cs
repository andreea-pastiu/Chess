namespace Chess.Exceptions
{
    public class MoveNotAllowedException: Exception
    {
        public MoveNotAllowedException(string message) : base(message)
        {
        }
    }
}
