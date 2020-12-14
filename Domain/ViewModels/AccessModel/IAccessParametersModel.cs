using Domain.Models;

namespace Domain.ViewModels.AccessModel
{
    public interface IAccessParametersModel
    {
        bool HasAccess(User user);
        AccessTypeModel GetAccessType();
    }
}