using System;
using System.Collections.Generic;
using LiteDB;

namespace Infrastructure.Records.Access
{
    [CollectionName("privates")]
    public class PrivateAccessRecord
    {
        [BsonId] 
        public Guid Id { get; set; }
        public HashSet<Guid> AccessedUsers { get; set; }
    }
}