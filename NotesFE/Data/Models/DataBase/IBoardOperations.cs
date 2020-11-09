using NotesFE.Data.Models.Domain;

namespace NotesFE.Data.Models.DataBase
{
    public interface IBoardOperations
    {
        public bool TryGetBoard(int id, ref Board board);
        public bool TryAddBoard(Board board);
    }
}