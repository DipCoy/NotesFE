using System;
using System.Collections.Generic;
using System.Linq;
using NotesFE.Data.Models.Domain;
using LiteDB;

namespace NotesFE.Data.Models.DataBase
{
    public class DefaultBoardOperations : IBoardOperations
    {
        private ILiteDatabase database;
        private string collectionName => "boards";
        public DefaultBoardOperations()
        {
            database = new LiteDatabase("Boards.db");
        }
        public bool TryGetBoard(int id, out Board board)
        {
            var collect = database.GetCollection<Board>(collectionName);
                board = collect.FindOne(b => b.Id == id);
                return board != null;
        }

        public bool TryAddBoard(Board board)
        {
            var collect = database.GetCollection<Board>(collectionName);
                collect.Insert(board);
                return true;
        }
    }
}