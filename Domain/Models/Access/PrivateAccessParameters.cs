using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models.Access
{
    public class PrivateAccessParameters : IAccessParameters
    {
        private HashSet<Guid> havingAccess;
        public HashSet<Guid> HavingAccess => havingAccess.ToHashSet();

        public PrivateAccessParameters(IEnumerable<Guid> whoHasAccess)
        {
            havingAccess = whoHasAccess.ToHashSet();
        }
        
        public bool HasAccess(User user)
        {
            return havingAccess.Contains(user.Id);
        }

        public AccessType GetType() => AccessType.Private;
    }
}