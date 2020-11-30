using System.Collections.Generic;

namespace Infrastructure.Records
{
    public class StickerRecord
    {
        //public IDictionary<string, string> Attributes;
        public StickerContentRecord Content { get; set; }
    }
}