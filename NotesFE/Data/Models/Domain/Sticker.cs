namespace NotesFE.Data.Models.Domain
{
    public class Sticker //value-type
    {
        public StickerAttributes Attributes { get; set; }
        public StickerContent Content { get; set; }

        public Sticker()
        {
            
        }
        public Sticker(StickerContent content)
        {
            Content = content;
        }
    }
}