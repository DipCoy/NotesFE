using NotesFE.Data.Models.Domain;
using LiteDB;

namespace NotesFE.Data.Models.DataBase
{
    public class DefaultBoardOperations : IBoardOperations
    {
        public bool TryGetBoard(int id, out Board board)
        {
            using (var db = new LiteDatabase(@"MyData.db"))
            {
                var collect = db.GetCollection<Board>("board");
                board = collect.FindById(id);
                if(board != null) //Хз что возвращает если нет такой записи
                    return true;
                return false;
            }
        }

        public bool TryAddBoard(Board board)
        {
            using (var db = new LiteDatabase(@"MyData.db"))
            {
                var collect = db.GetCollection<Board>("board");
                collect.Insert(board);
                return true;
            }
        }
    }
}