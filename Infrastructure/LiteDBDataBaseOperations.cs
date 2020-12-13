using System;
using System.Linq;
using System.Linq.Expressions;
using LiteDB;

namespace Infrastructure
{
    public class LiteDBDataBaseOperations : IDataBaseOperations
    {
        private readonly ILiteDatabase database;

        public LiteDBDataBaseOperations(ILiteDatabase database)
        {
            this.database = database;
        }

        public bool TryGetRecord<TRecord>(Expression<Func<TRecord, bool>> filter, out TRecord record)
        {
            var collectionName = GetCollectionName<TRecord>();
            var collection = database.GetCollection<TRecord>(collectionName);

            record = collection.FindOne(filter);
            return !(record is null);
            
        }

        public bool TryAddRecord<TRecord>(TRecord record)
        {
            var collectionName = GetCollectionName<TRecord>();
            try
            {
                database
                    .GetCollection<TRecord>(collectionName)
                    .Insert(record);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private string GetCollectionName<TRecord>()
        {
            var t = typeof(TRecord);
            object[] attributes = t.GetCustomAttributes(typeof(CollectionNameAttribute), false);
            
            if (attributes.Length == 0)
                throw new ArgumentException("Should have CollectionNameAttribute");
            return ((CollectionNameAttribute) attributes.First()).Name;
        }
    }
}