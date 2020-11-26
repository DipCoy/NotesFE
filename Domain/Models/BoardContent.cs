using System.Collections.Generic;

namespace Domain.Models
{
    public class BoardContent//entity
    {
        public IEnumerable<Sticker> Stickers { get; private set; }
        
        public BoardContent(IEnumerable<Sticker> stickers)
        {
            Stickers = stickers;
        }
    }
}