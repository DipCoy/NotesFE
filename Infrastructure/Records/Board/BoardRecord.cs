using System;
using Infrastructure.Records.Access;
using LiteDB;

namespace Infrastructure.Records.Board
{
    [CollectionName("boards")]
    public class BoardRecord
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Link { get; set; }
        public BoardContentRecord Content{ get; set; }
        
        public AccessTypeRecord AccessType { get; set; }
    }
}