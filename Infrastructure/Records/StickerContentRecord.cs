using System;
using System.Collections.Generic;

namespace Infrastructure.Records
{
    public class StickerContentRecord
    {
        public string Text { get; set; }
        public TimeTableRecord TimeTable { get; set; }
    }
}