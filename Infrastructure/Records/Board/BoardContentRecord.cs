using System.Collections.Generic;

namespace Infrastructure.Records.Board
{
    public class BoardContentRecord
    {
        public IEnumerable<StickerRecord> Stickers { get; set; }
    }
}