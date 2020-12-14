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
        private AllPossibleAccessServices allPossibleAccessServices;
        
        public BoardConverter(IConverter<BoardContentRecord, BoardContent> boardContentConverter, 
            AllPossibleAccessServices allPossibleAccessServices)
        {
            this.boardContentConverter = boardContentConverter;
            this.allPossibleAccessServices = allPossibleAccessServices;
        }

        public Board Convert(BoardRecord record)
        {
            IAccessParameters accessParameters;
            switch (record.AccessType)
            {
                case AccessTypeRecord.Private:
                    accessParameters = allPossibleAccessServices.Services[AccessType.Private].FromLink(record.AccessInformation);
                    break;
                case AccessTypeRecord.Public:
                    accessParameters = allPossibleAccessServices.Services[AccessType.Public].FromLink(record.AccessInformation);
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