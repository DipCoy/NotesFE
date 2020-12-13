using System;

namespace Domain.Models.Access
{
    public class OnlyOwnerAccessParameters : IAccessParameters
    {
        private Guid owner;

        public OnlyOwnerAccessParameters(User owner)
        {
            this.owner = owner.Id;
        }
        public bool HasAccess(User user)
        {
            return user.Id == owner;
        }

        public AccessType GetType() => AccessType.Owner;
    }
}