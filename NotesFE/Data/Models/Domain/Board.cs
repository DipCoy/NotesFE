using System.Collections.Generic;

namespace NotesFE.Data.Models.Domain
{
    public class Board //entity
    {
        private int Id { get; set; }
        public BoardAttributes Attributes { get; private set; }
        public BoardContent Content { get; private set; }
    }
}