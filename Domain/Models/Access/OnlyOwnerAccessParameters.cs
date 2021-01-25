using System;

namespace Domain.Models.Access
{
    public class OnlyOwnerAccessParameters : IAccessParameters
    {
        private readonly Guid owner;

        public OnlyOwnerAccessParameters(User.User owner)
        {
            this.owner = owner.Id;
        }

        public bool HasAccess(User.User user) => user.Id == owner;

        public AccessType GetAccessType() => AccessType.Owner;
    }
}