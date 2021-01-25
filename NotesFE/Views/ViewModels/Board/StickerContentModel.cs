using System.Collections.Generic;

namespace NotesFE.Views.ViewModels.Board
{
    public class StickerContentModel
    {
        public string Text { get; set; }
        public IEnumerable<IEnumerable<string>> TimeTable { get; set; }
    }
}