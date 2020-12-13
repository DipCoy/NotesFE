using System;
using Application.Converters;
using Domain.Models;
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

        public DefaultBoardService(IDataBaseOperations dataBase, IConverter<BoardRecord, Board> boardConverter, ILinkGenerator linkGenerator)
        {
            this.dataBase = dataBase;
            this.boardConverter = boardConverter;
            this.linkGenerator = linkGenerator;
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
            boardRecord.AccessInformation = Guid.NewGuid();

            if (boardRecord.AccessType != AccessTypeRecord.Public)
            {
                
            }
            return dataBase.TryAddRecord(boardRecord);
        }
    }
}