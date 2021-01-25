using System.Collections.Generic;
using Domain.Models.Access;
using Infrastructure.DataBases;

namespace Application.Services.Access
{
    public class AllPossibleAccessServices
    {
        public Dictionary<AccessType, IAccessService> Services { get; }
        private readonly IDataBaseOperations database;

        public AllPossibleAccessServices(IDataBaseOperations database)
        {
            this.database = database;
            Services = new Dictionary<AccessType, IAccessService>()
            {
                {AccessType.Public, new PublicAccessService()},
                {AccessType.Private, new PrivateAccessService(this.database)}
            };
        }
    }
}