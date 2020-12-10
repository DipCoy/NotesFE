using System;
using System.Linq;
using System.Linq.Expressions;
using Infrastructure.Records;
using LiteDB;

namespace Infrastructure
{
    public class DefaultBoardOperations : IBoardOperations
    {
        private readonly ILiteDatabase database;
        private string collectionName => "boards";
        public DefaultBoardOperations(ILiteDatabase database)
        {
            this.database = database;
        }

        public bool TryGetBoardRecord(string link, out BoardRecord boardRecord)
        {
            var collection = database.GetCollection<BoardRecord>(collectionName);
            // collection.EnsureIndex(s => s.Link);
            //var boards = collection.FindAll();

            //var ls = boards.ToList();
            //boardRecord = collection.Find(Query.)
            boardRecord = collection.FindOne(x => x.Link == link);
            return !(boardRecord is null);
            //boardRecord = database
            //    .GetCollection<BoardRecord>(collectionName)
            //    .FindOne(board => predicate(board));
            //return !(boardRecord is null);
        }

        public bool TryAddBoardRecord(BoardRecord boardRecord)
        {
            try
            {
                database
                    .GetCollection<BoardRecord>(collectionName)
                    .Insert(boardRecord);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}