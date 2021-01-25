using System;
using Application.Services.Access;
using Domain.Models.Access;
using Domain.Models.Board;
using Infrastructure.Records.Access;
using Infrastructure.Records.Board;

namespace Application.Converters.Board
{
    public class BoardConverter: IConverter<BoardRecord, Domain.Models.Board.Board>
    {
        private readonly IConverter<BoardContentRecord, BoardContent> boardContentConverter;
        private AllPossibleAccessServices allPossibleAccessServices;
        
        public BoardConverter(IConverter<BoardContentRecord, BoardContent> boardContentConverter, 
            AllPossibleAccessServices allPossibleAccessServices)
        {
            this.boardContentConverter = boardContentConverter;
            this.allPossibleAccessServices = allPossibleAccessServices;
        }

        public Domain.Models.Board.Board Convert(BoardRecord record)
        {
            IAccessParameters accessParameters;
            switch (record.AccessType)
            {
                case AccessTypeRecord.Private:
                    accessParameters = allPossibleAccessServices.Services[AccessType.Private].FromLink(record.Link);
                    break;
                case AccessTypeRecord.Public:
                    accessParameters = allPossibleAccessServices.Services[AccessType.Public].FromLink(record.Link);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return new Domain.Models.Board.Board(boardContentConverter.Convert(record.Content), accessParameters);
        }

        public BoardRecord Convert(Domain.Models.Board.Board source)
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