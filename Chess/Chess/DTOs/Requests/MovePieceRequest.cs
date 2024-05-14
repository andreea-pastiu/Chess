namespace Chess.DTOs.Requests
{
    public class MovePieceRequest
    {
        public Guid GameId { get; set; }
        public int PlayerId { get; set; }
        public int PieceX { get; set; }
        public int PieceY { get; set; }
        public int NewX { get; set; }
        public int NewY { get; set; }
    }
}
