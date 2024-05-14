namespace Chess.Exceptions
{
    public class NotYourTurnException: Exception
    {
        public NotYourTurnException(string message) : base(message)
        {
        }
    }
}
