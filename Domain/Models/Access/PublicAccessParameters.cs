namespace Domain.Models.Access
{
    public class PublicAccessParameters : IAccessParameters
    {
        public bool HasAccess(User.User user) => true;

        public AccessType GetAccessType() => AccessType.Public;
    }
}