using System;
using System.Collections.Generic;
using NotesFE.Data.Models.Domain;

namespace NotesFE.Data.Models.DataBase.Records
{
    public class BoardContentRecord : IRecord
    {
        public IEnumerable<StickerRecord> Stickers;
        public IHaveRecord FromRecord()
        {
            throw new NotImplementedException();
        }
    }
}