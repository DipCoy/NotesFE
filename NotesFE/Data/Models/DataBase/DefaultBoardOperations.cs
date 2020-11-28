using System;
using System.Collections.Generic;
using System.Linq;
using NotesFE.Data.Models.Domain;
using LiteDB;

namespace NotesFE.Data.Models.DataBase
{
    public class DefaultBoardOperations : IBoardOperations
    {
        public bool TryGetBoard(int id, out Board board)
        {
            using (var db = new LiteDatabase(@"Boards.db"))
            {
                var collect = db.GetCollection<Board>("boards");
                board = collect.FindOne(b => b.Id == id);
                return board != null;
            }
        }

        public bool TryAddBoard(Board board)
        {
            using (var db = new LiteDatabase(@"Boards.db"))
            {
                var collect = db.GetCollection<Board>("boards");
                collect.Insert(board);
                return true;
            }
        }
    }
}