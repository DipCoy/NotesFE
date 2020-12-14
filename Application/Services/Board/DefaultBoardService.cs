using System;
using Application.Converters;
using Domain.Models;
using Domain.Models.Access;
using Infrastructure;
using Infrastructure.Records;
using Infrastructure.Records.Access;

namespace Application
{
    public class DefaultBoardService: IBoardService
    {
        private readonly IDataBaseOperations dataBase;
        private readonly IConverter<BoardRecord, Board> boardConverter;
        private readonly ILinkGenerator linkGenerator;
        private readonly IConverter<PrivateAccessRecord, PrivateAccessParameters> privateAccessConverter;
        
        public DefaultBoardService(IDataBaseOperations dataBase, 
            IConverter<BoardRecord, Board> boardConverter, 
            ILinkGenerator linkGenerator,
            IConverter<PrivateAccessRecord, PrivateAccessParameters> privateAccessConverter)
        {
            this.dataBase = dataBase;
            this.boardConverter = boardConverter;
            this.linkGenerator = linkGenerator;
            this.privateAccessConverter = privateAccessConverter;
        }

        public bool TryGetBoard(string link, out Board board)
        {
            if (dataBase.TryGetRecord<BoardRecord>(x => x.Link == link, out var boardRecord))
            {
                board = boardConverter.Convert(boardRecord);
                return true;
            }

            board = null;
            return false;
        }

        public bool TryAddBoard(Board board, out string link)
        {
            var boardRecord = boardConverter.Convert(board);
            link = linkGenerator.NewLink();
            boardRecord.Link = link;

            var isAddingAccessRecordSuccess = true;
            switch (boardRecord.AccessType)
            {
                case AccessTypeRecord.Public:
                    break;
                case AccessTypeRecord.Private:
                    var record = privateAccessConverter.Convert((PrivateAccessParameters)board.AccessParameters);
                    record.Link = boardRecord.Link;
                    isAddingAccessRecordSuccess = dataBase.TryAddRecord(record, out var _);
                    break;
                default:
                    throw new NotImplementedException();
            }
            
            return isAddingAccessRecordSuccess && dataBase.TryAddRecord(boardRecord, out var _);
        }
    }
}