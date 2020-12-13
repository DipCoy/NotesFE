namespace Domain.Models.Access
{
    public class PublicAccessParameters : IAccessParameters
    {
        public bool HasAccess(User user)
        {
            return true;
        }

        public AccessType GetType() => AccessType.Public;
    }
}