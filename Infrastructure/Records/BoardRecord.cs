using System;
using LiteDB;

namespace Infrastructure.Records
{
    public class BoardRecord
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Link { get; set; }
        public BoardContentRecord Content{ get; set; }
    }
}