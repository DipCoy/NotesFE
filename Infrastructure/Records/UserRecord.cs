using System;
using LiteDB;

namespace Infrastructure.Records
{
    public class UserRecord
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password{ get; set; }
    }
}