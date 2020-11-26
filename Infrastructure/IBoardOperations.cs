using Infrastructure.Records;

namespace Infrastructure
{
    public interface IBoardOperations
    {
        public bool TryGetBoardRecord(int id, out BoardRecord boardRecord);
        public bool TryAddBoardRecord(BoardRecord boardRecord);
    }
}