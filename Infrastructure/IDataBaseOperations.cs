using System;
using System.Linq.Expressions;

namespace Infrastructure
{
    public interface IDataBaseOperations
    {
        bool TryGetRecord<TRecord>(Expression<Func<TRecord, bool>> filter, out TRecord record);
        bool TryAddRecord<TRecord>(TRecord record);

    }
}