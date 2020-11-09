namespace NotesFE.Data.Models.Domain
{
    public class Sticker //value-type
    {
        public StickerAttributes Attributes { get; private set; }
        public StickerContent Content { get; private set; }
    }
}