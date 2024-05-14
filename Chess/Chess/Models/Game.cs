namespace Chess.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        public List<Player> PlayerList { get; set; }
        public PieceColor Turn { get; set; } 
    }
}
