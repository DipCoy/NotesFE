using System.Collections.Generic;

namespace NotesFE.Data.Models.Domain
{
    public class BoardContent //entity
    {
        public IEnumerable<Sticker> Stickers { get; set; }

        public BoardContent()
        {
            
        }
        public BoardContent(IEnumerable<Sticker> stickers)
        {
            Stickers = stickers;
        }
    }
}