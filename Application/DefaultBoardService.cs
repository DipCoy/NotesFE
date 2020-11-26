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

        public bool TryGetBoard(int id, out Board board)
        {
            if (dataBase.TryGetBoardRecord(id, out var boardRecord))
            {
                board = boardConverter.Convert(boardRecord);
                return true;
            }

            board = null;
            return false;
        }

        public bool TryAddBoard(Board board)
        {
            var boardRecord = new BoardRecord {Id = 1}; // TODO board -> BoardRecord

            return dataBase.TryAddBoardRecord(boardRecord);
        }
    }
}