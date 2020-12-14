namespace Domain.Models.Access
{
    public class PublicAccessParameters : IAccessParameters
    {
        public bool HasAccess(User user) => true;

        public AccessType GetAccessType() => AccessType.Public;
    }
}