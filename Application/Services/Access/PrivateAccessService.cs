using System;
using Domain.Models.Access;
using Infrastructure.DataBases;
using Infrastructure.Records.Access;

namespace Application.Services.Access
{
    public class PrivateAccessService : IAccessService
    {
        private readonly IDataBaseOperations dataBase;

        public PrivateAccessService(IDataBaseOperations dataBaseOperations)
        {
            dataBase = dataBaseOperations;
        }

        public IAccessParameters FromLink(string link)
        {
            if (!dataBase.TryGetRecord<PrivateAccessRecord>(x => x.Link == link, out var accessParamsRecord))
                throw new ArgumentException("Link does not exist");

            return new PrivateAccessParameters(accessParamsRecord.AccessedUsers);
        }
    }
}