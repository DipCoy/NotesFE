namespace NotesFE.Data.Models.Domain
{
    public class Sticker//value-type
    {
        public StickerContent Content { get; private set; }
        
        public Sticker(StickerContent content)
        {
            Content = content;
        }
    }
}