using System;
using Infrastructure.Records;
using LiteDB;

namespace Infrastructure
{
    public class DefaultBoardOperations : IBoardOperations
    {
        private readonly ILiteDatabase database;
        private string collectionName => "boards";
        public DefaultBoardOperations()
        {
            database = new LiteDatabase("Boards.db");
        }

        public bool TryGetBoardRecord(int id, out BoardRecord boardRecord)
        {
            boardRecord = database
                .GetCollection<BoardRecord>(collectionName)
                .FindOne(b => b.Id == id);
            return !(boardRecord is null);
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