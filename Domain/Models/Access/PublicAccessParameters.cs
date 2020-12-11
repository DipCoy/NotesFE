namespace Domain.Models
{
    public class PublicAccessParameters : IAccessParameters
    {
        public bool HasAccess(User user)
        {
            return true;
        }
    }
}