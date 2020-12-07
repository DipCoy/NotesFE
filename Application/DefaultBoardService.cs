using Application.Converters;
using Domain.Models;
using Infrastructure;
using Infrastructure.Records;

namespace Application
{
    public class DefaultBoardService: IBoardService
    {
        private readonly IBoardOperations dataBase;
        private readonly IConverter<BoardRecord, Board> boardConverter;

        public DefaultBoardService(IBoardOperations dataBase, IConverter<BoardRecord, Board> boardConverter)
        {
            this.dataBase = dataBase;
            this.boardConverter = boardConverter;
        }

        public bool TryGetBoard(string link, out Board board)
        {
            if (dataBase.TryGetBoardRecord(link, out var boardRecord))
            {
                board = boardConverter.Convert(boardRecord);
                return true;
            }

            board = null;
            return false;
        }

        public bool TryAddBoard(Board board)
        {
            board.GenerateNewLink();
            return dataBase.TryAddBoardRecord(boardConverter.Convert(board));
        }
    }
}