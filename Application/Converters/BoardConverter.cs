using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Models;
using Infrastructure.Records;
using Infrastructure.Records.Access;

namespace Application.Converters
{
    public class BoardConverter: IConverter<BoardRecord, Board>
    {
        private readonly IConverter<BoardContentRecord, BoardContent> boardContentConverter;
        
        private Dictionary<AccessTypeRecord, IAccessConverter> accessConverters;

        public BoardConverter(IConverter<BoardContentRecord, BoardContent> boardContentConverter, 
            PublicAccessConverter publicAccessConverter, 
            PrivateAccessConverter privateAccessConverter)
        {
            this.boardContentConverter = boardContentConverter;
            accessConverters[AccessTypeRecord.Public] = publicAccessConverter;
            accessConverters[AccessTypeRecord.Private] = privateAccessConverter;
        }

        public Board Convert(BoardRecord record)
        {
            var accessParams = accessConverters[record.AccessType].Get(record.AccessType);
            var acParams = dict[record.enum].getAccessParameters(record.AccessParamDocId);
            return new Board(boardContentConverter.Convert(record.Content), record.WhoHasAccess);
        }

        public BoardRecord Convert(Board source)
        {
            return new BoardRecord()
            {
                Id = source.Id,
                Content = boardContentConverter.Convert(source.Content),
                WhoHasAccess = source.WhoHasAccess
            };
        }
    }
}