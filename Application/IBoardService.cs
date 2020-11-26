using Domain.Models;

namespace Application.Converters
{
    public interface IBoardService
    {
        public bool TryGetBoard(int id, out Board board);
        public bool TryAddBoard(Board board);
    }
}