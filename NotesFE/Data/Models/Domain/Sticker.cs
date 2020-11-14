namespace NotesFE.Data.Models.Domain
{
    public class Sticker : IHaveRecord//value-type
    {
        public StickerAttributes Attributes { get; private set; }
        public StickerContent Content { get; private set; }
        
        public Sticker(StickerContent content)
        {
            Content = content;
        }
    }
}