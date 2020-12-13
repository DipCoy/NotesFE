using System;
using System.Collections.Generic;
using LiteDB;

namespace Infrastructure.Records
{
    public class BoardRecord
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Link { get; set; }
        public BoardContentRecord Content{ get; set; }
        public HashSet<Guid> WhoHasAccess { get; set; }
        
    }
}