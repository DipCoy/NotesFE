using System.Collections.Generic;

namespace Infrastructure.Records.Board
{
    public class StickerContentRecord
    {
        public string Text { get; set; }
        public IEnumerable<IEnumerable<string>> TimeTable { get; set; }
    }
}