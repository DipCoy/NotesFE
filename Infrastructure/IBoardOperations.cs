using Domain;

namespace Infrastructure
{
    public interface IBoardOperations
    {
        public bool TryGetBoard(int id, out Board board);
        public bool TryAddBoard(Board board);
    }
}