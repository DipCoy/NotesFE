using System;

namespace Domain.Models
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
    }
}