namespace Domain.Models
{
    public class StickerContent
    {
        public string Text { get; private set; }

        public StickerContent(string text)
        {
            Text = text;
        }
    }
}