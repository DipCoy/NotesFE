using Domain.Models;

namespace Application
{
    public interface IBoardService
    {
        public bool TryGetBoard(string link, out Board board);
        public bool TryAddBoard(Board board, out string link);
    }
}