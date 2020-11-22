using Domain;
using Infrastructure.Records;

namespace Infrastructure.Converter
{
    public class BoardConverter
    {
        private readonly BoardContentConverter boardContentConverter;

        public BoardConverter(BoardContentConverter boardContentConverter)
        {
            this.boardContentConverter = boardContentConverter;
        }

        public Board Convert(BoardRecord record)
        {
            return new Board(record.Id, boardContentConverter.Convert(record.Content));
        }
    }
}