using System.Collections.Generic;

namespace NotesFE.Data.Models.Domain
{
    public class BoardContent : IHaveRecord//entity
    {
        public IEnumerable<Sticker> Stickers { get; private set; }
        
        public BoardContent(IEnumerable<Sticker> stickers)
        {
            Stickers = stickers;
        }
    }
}