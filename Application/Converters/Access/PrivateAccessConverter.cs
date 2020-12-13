using System;
using Domain.Models.Access;
using Infrastructure;
using Infrastructure.Records.Access;

namespace Application.Converters.Access
{
    public class PrivateAccessConverter : IAccessConverter
    {
        private readonly IDataBaseOperations dataBase;

        public PrivateAccessConverter(IDataBaseOperations dataBaseOperations)
        {
            dataBase = dataBaseOperations;
        }

        public IAccessParameters Get(Guid guid)
        {
            if (!dataBase.TryGetRecord<PrivateAccessRecord>(x => x.Id == guid, out var accessParamsRecord))
                throw new ArgumentException("Guid does not exist");

            return new PrivateAccessParameters(accessParamsRecord.AccessedUsers);
        }
    }
}