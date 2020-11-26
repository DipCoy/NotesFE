using System;
using Infrastructure.Records;
using LiteDB;

namespace Infrastructure
{
    public class DefaultBoardOperations : IBoardOperations
    {
        private ILiteDatabase database;
        private string collectionName => "boards";
        public DefaultBoardOperations()
        {
            database = new LiteDatabase("Boards.db");
        }

        public bool TryGetBoardRecord(int id, out BoardRecord boardRecord)
        {
            try
            {
                var collect = database.GetCollection<BoardRecord>(collectionName);
                // foreach (var b in collect.FindAll())
                // {
                //     Console.WriteLine(b.Id);
                // }
                boardRecord = collect.FindOne(b => b.Id == id);
                return true;
            }
            catch
            {
                boardRecord = null;
                return false;
            }
        }

        public bool TryAddBoardRecord(BoardRecord boardRecord)
        {
            try
            {
                var collect = database.GetCollection<BoardRecord>(collectionName);
                collect.Insert(boardRecord);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}