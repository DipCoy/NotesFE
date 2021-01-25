namespace Domain.Models.Board
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