using System.Collections.Generic;

namespace Infrastructure.Records
{
    public class BoardContentRecord
    {
        public IEnumerable<StickerRecord> Stickers { get; set; }
    }
}