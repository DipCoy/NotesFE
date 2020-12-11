namespace Domain.Models
{
    public interface IAccessParameters
    {
        bool HasAccess(User user);
    }
}