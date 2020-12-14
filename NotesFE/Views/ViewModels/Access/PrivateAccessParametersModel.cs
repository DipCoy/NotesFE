using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Models;

namespace Domain.ViewModels.AccessModel
{
    public class PrivateAccessParametersModel : IAccessParametersModel
    {
        private readonly HashSet<Guid> havingAccess;

        public PrivateAccessParametersModel(IEnumerable<Guid> whoHasAccess)
        {
            havingAccess = whoHasAccess.ToHashSet();
        }

        public bool HasAccess(User user) => havingAccess.Contains(user.Id);

        public AccessTypeModel GetAccessType() => AccessTypeModel.Private;
    }
}