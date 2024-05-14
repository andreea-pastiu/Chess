namespace Chess.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public PieceColor Turn { get; set; } 
    }
}
