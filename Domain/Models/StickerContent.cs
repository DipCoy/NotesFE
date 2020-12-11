namespace Domain.Models
{
    public class StickerContent
    {
        public string Text { get; set; }

        public StickerContent(string text)
        {
            Text = text;
        }
    }
}