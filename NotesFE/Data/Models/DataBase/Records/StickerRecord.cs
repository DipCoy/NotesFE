using System.Collections.Generic;
using NotesFE.Data.Models.Domain;

namespace NotesFE.Data.Models.DataBase.Records
{
    public class StickerRecord
    {
        public IDictionary<string, string> Attributes;
        public StickerContentRecord Content;
    }
}