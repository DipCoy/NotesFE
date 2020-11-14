using System.Collections.Generic;
using System.Linq;

namespace NotesFE.Data.Models.Domain
{
    public class Board //entity
    {
        public int Id { get; set;}
        public BoardAttributes Attributes { get; set; }
        public BoardContent Content { get; set; }

        public Board()
        {
            
        }
        public Board(int id, BoardContent content)
        {
            Id = id;
            Content = content;
        }

        public override string ToString()
        {
            return Content.Stickers.First().Content.Text;
        }
    }
}