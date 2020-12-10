using System;
using System.Linq;

namespace Domain.Models
{
    public class Board//entity
    {
        public Guid Id { get; private set;}
        public BoardContent Content { get; private set; }
        
        public Board(BoardContent content)
        {
            Content = content;
        }
    }
}