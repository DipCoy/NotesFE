using System.Collections.Generic;

namespace Domain.Models
{
    public class StickerContent
    {
        public string Text { get; set; }
        public IEnumerable<IEnumerable<string>> TimeTable { get; set; }

        public StickerContent(string text, IEnumerable<IEnumerable<string>> timeTable)
        {
            Text = text;
            TimeTable = timeTable;
        }
    }
}