﻿using Chess.Models;

namespace Chess.DTOs.Responses
{
    public class GameDTO
    {
        public Guid Id { get; set; }
        public string[][] Board { get; set; }
        public PieceColor Turn { get; set; }
    }
}
