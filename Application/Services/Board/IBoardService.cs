namespace Application.Services.Board
{
    public interface IBoardService
    {
        public bool TryGetBoard(string link, out Domain.Models.Board.Board board);
        public bool TryAddBoard(Domain.Models.Board.Board board, out string link);
        public bool TryUpdateBoard(Domain.Models.Board.Board board, string link);
    }
}