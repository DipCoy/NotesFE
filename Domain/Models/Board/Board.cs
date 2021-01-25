using System;
using Domain.Models.Access;

namespace Domain.Models.Board
{
    public class Board//entity
    {
        public Guid Id { get; private set;}
        public BoardContent Content { get; private set; }
        public IAccessParameters AccessParameters { get; private set; }

        public Board(BoardContent content, IAccessParameters accessParameters)
        {
            Content = content;
            AccessParameters = accessParameters;
        }
    }
}