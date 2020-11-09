using NotesFE.Data.Models.Domain;

namespace NotesFE.Data.Models.DataBase
{
    public class DefaultBoardOperations : IBoardOperations
    {
        public bool TryGetBoard(int id, ref Board board)
        {
            throw new System.NotImplementedException();
        }

        public bool TryAddBoard(Board board)
        {
            throw new System.NotImplementedException();
        }
    }
}