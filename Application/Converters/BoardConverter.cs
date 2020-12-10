using System;
using System.Linq;
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
            return new Board(boardContentConverter.Convert(record.Content));
        }

        public BoardRecord Convert(Board source)
        {
            return new BoardRecord()
            {
                Id = source.Id,
                Content = boardContentConverter.Convert(source.Content)
            };
        }
    }
}