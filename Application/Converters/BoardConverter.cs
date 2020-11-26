using Domain.Models;
using Infrastructure.Records;

namespace Application.Converters
{
    public class BoardConverter: IConverter<BoardRecord, Board>
    {
        private readonly IConverter<BoardContentRecord, BoardContent> boardContentConverter;

        public BoardConverter(IConverter<BoardContentRecord, BoardContent> boardContentConverter)
        {
            this.boardContentConverter = boardContentConverter;
        }

        public Board Convert(BoardRecord record)
        {
            return new Board(record.Id, boardContentConverter.Convert(record.Content));
        }
    }
}