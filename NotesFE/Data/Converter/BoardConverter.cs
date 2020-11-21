using NotesFE.Data.Models.DataBase.Records;
using NotesFE.Data.Models.Domain;

namespace NotesFE.Data.Converter
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