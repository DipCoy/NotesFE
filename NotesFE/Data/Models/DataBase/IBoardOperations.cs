using NotesFE.Data.Models.Domain;

namespace NotesFE.Data.Models.DataBase
{
    public interface IBoardOperations
    {
        public bool TryGetBoard(int id, out Board board);
        public bool TryAddBoard(Board board);
    }
}