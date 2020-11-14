using System.Collections.Generic;
using NotesFE.Data.Models.Domain;

namespace NotesFE.Data.Models.DataBase.Records
{
    public class BoardRecord : IRecord
    {
        public int Id;
        public IDictionary<string, string> Attributes;
        public BoardContentRecord Content;

        public IHaveRecord FromRecord()
        {
            var board = new Board(Id, (BoardContent) Content.FromRecord());
            throw new System.NotImplementedException();
        }
    }
}