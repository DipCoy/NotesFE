using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public class PrivateAccessParameters : IAccessParameters
    {
        private HashSet<Guid> havingAccess;

        public PrivateAccessParameters(IEnumerable<Guid> whoHasAccess)
        {
            havingAccess = whoHasAccess.ToHashSet();
        }
        
        public bool HasAccess(User user)
        {
            return havingAccess.Contains(user.Id);
        }
    }
}