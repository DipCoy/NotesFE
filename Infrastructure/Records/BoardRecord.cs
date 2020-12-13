using System;
using System.Collections.Generic;
using Infrastructure.Records.Access;
using LiteDB;

namespace Infrastructure.Records
{
    [CollectionName("boards")]
    public class BoardRecord
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Link { get; set; }
        public BoardContentRecord Content{ get; set; }
        
        public AccessTypeRecord AccessType { get; set; }
        public Guid AccessInformation;
    }
}