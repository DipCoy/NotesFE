using System;
using Infrastructure.Records;

namespace Infrastructure
{
    public interface IBoardOperations
    {
        public bool TryGetBoardRecord(string link, out BoardRecord boardRecord);
        public bool TryAddBoardRecord(BoardRecord boardRecord);
    }
}