namespace Domain.Models
{
    public class Sticker//value-type
    {
        public StickerContent Content { get; set; }
        
        public Sticker(StickerContent content)
        {
            Content = content;
        }
    }
}