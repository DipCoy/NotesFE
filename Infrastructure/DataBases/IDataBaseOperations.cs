using System;
using System.Linq.Expressions;
using Infrastructure.Records.Board;

namespace Infrastructure.DataBases
{
    public interface IDataBaseOperations
    {
        bool TryGetRecord<TRecord>(Expression<Func<TRecord, bool>> filter, out TRecord record);
        bool TryAddRecord<TRecord>(TRecord record, out Guid guid);
        bool TryDeleteBoard(string link);

    }
}