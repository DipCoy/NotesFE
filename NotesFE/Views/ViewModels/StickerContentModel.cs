using System;
using System.Collections.Generic;

namespace Domain.ViewModels
{
    public class StickerContentModel
    {
        public string Text { get; set; }
        public IEnumerable<IEnumerable<string>> TimeTable { get; set; }
    }
}