using System;
using Application.Converters;
using Application.Services.Link;
using Domain.Models.Access;
using Infrastructure.DataBases;
using Infrastructure.Records.Access;
using Infrastructure.Records.Board;

namespace Application.Services.Board
{
    public class DefaultBoardService: IBoardService
    {
        private readonly IDataBaseOperations dataBase;
        private readonly IConverter<BoardRecord, Domain.Models.Board.Board> boardConverter;
        private readonly ILinkGenerator linkGenerator;
        private readonly IConverter<PrivateAccessRecord, PrivateAccessParameters> privateAccessConverter;
        
        public DefaultBoardService(IDataBaseOperations dataBase, 
            IConverter<BoardRecord, Domain.Models.Board.Board> boardConverter, 
            ILinkGenerator linkGenerator,
            IConverter<PrivateAccessRecord, PrivateAccessParameters> privateAccessConverter)
        {
            this.dataBase = dataBase;
            this.boardConverter = boardConverter;
            this.linkGenerator = linkGenerator;
            this.privateAccessConverter = privateAccessConverter;
        }

        public bool TryGetBoard(string link, out Domain.Models.Board.Board board)
        {
            if (dataBase.TryGetRecord<BoardRecord>(x => x.Link == link, out var boardRecord))
            {
                board = boardConverter.Convert(boardRecord);
                return true;
            }

            board = null;
            return false;
        }

        public bool TryAddBoard(Domain.Models.Board.Board board, out string link)
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
        
        public bool TryUpdateBoard(Domain.Models.Board.Board board, string link)
        {
            var boardRecord = boardConverter.Convert(board);
            boardRecord.Link = link;

            var delete = dataBase.TryDeleteBoard(link);

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
            
            return delete 
                   && isAddingAccessRecordSuccess
                   && dataBase.TryAddRecord(boardRecord, out var _);
        }
    }
}