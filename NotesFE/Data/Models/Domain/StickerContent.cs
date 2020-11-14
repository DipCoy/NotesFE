namespace NotesFE.Data.Models.Domain
{
    public class StickerContent : IHaveRecord
    {
        public string Text { get; private set; }

        public StickerContent(string text)
        {
            Text = text;
        }
    }
}