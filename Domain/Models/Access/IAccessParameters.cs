namespace Domain.Models.Access
{
    public interface IAccessParameters
    {
        bool HasAccess(User.User user);
        AccessType GetAccessType();
    }
}