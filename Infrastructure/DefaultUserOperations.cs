using System;
using System.Linq.Expressions;
using Infrastructure.Records;
using LiteDB;

namespace Infrastructure
{
    public class DefaultUserOperations : IUserOperations
    {
        private readonly ILiteDatabase database;
        private string collectionName => "users";
        
        public DefaultUserOperations(ILiteDatabase database)
        {
            this.database = database;
        }
        
        public bool TryGetUserRecord(string login, out UserRecord userRecord)
        {
            var result = TryGetRecord<UserRecord>(x => x.Login == login, out var record);
            

            return
            var collection = database.GetCollection<UserRecord>(collectionName);
            collection.EnsureIndex(s => s.Login);
            userRecord = collection.FindOne(x => x.Login == login);
            return !(userRecord is null);
        }

        public bool TryGetRecord<TRecord>(Expression<Func<TRecord, bool>> filter, out TRecord record)
        {
            
        }

        public bool TryAddUserRecord(UserRecord userRecord)
        {
            try
            {
                database
                    .GetCollection<UserRecord>(collectionName)
                    .Insert(userRecord);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}