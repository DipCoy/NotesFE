using System.Collections.Generic;
using NotesFE.Data.Models.Domain;

namespace NotesFE.Data.Models.DataBase.Records
{
    public class BoardRecord
    {
        public int Id;
        public IDictionary<string, string> Attributes;
        public BoardContentRecord Content;
    }
}