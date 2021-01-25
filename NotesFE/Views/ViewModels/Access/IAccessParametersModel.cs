using Domain.Models.User;

namespace NotesFE.Views.ViewModels.Access
{
    public interface IAccessParametersModel
    {
        bool HasAccess(User user);
        AccessTypeModel GetAccessType();
    }
}