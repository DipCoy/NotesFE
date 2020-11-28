namespace NotesFE.Data.Models.Domain
{
    public class StickerContent
    {
        public string Text { get; set; }

        public StickerContent(string text)
        {
            Text = text;
        }

        public StickerContent()
        {
            
        }
    }
}