using System;
using System.Collections.Generic;
using System.Linq;
using Application.Converters.Access;
using Domain.Models;
using Domain.Models.Access;
using Infrastructure.Records;
using Infrastructure.Records.Access;

namespace Application.Converters
{
    public class BoardConverter: IConverter<BoardRecord, Board>
    {
        private readonly IConverter<BoardContentRecord, BoardContent> boardContentConverter;
        
        private Dictionary<AccessType, IAccessConverter> accessConverters;

        public BoardConverter(IConverter<BoardContentRecord, BoardContent> boardContentConverter)
        {
            this.boardContentConverter = boardContentConverter;
        }

        public Board Convert(BoardRecord record)
        {
            IAccessParameters accessParameters;
            switch (record.AccessType)
            {
                case AccessTypeRecord.Private:
                    accessParameters = accessConverters[AccessType.Private].Get(record.AccessInformation);
                    break;
                case AccessTypeRecord.Public:
                    accessParameters = accessConverters[AccessType.Public].Get(record.AccessInformation);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return new Board(boardContentConverter.Convert(record.Content), accessParameters);
        }

        public BoardRecord Convert(Board source)
        {
            AccessTypeRecord accessTypeRecord;
            switch (source.AccessParameters.GetAccessType())
            {
                case AccessType.Private:
                    accessTypeRecord = AccessTypeRecord.Private;
                    break;
                case AccessType.Public:
                    accessTypeRecord = AccessTypeRecord.Public;
                    break;
                default:
                    throw new NotImplementedException();
            }
            
            return new BoardRecord()
            {
                Id = source.Id,
                Content = boardContentConverter.Convert(source.Content),
                AccessType = accessTypeRecord
            };
        }
    }
}