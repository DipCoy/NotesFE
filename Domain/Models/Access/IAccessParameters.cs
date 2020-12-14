namespace Domain.Models.Access
{
    public interface IAccessParameters
    {
        bool HasAccess(User user);
        AccessType GetAccessType();
    }
}