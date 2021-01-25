using Domain.Models.User;

namespace NotesFE.Views.ViewModels.Access
{
    public class PublicAccessParametersModel : IAccessParametersModel
    {
        public bool HasAccess(User user) => true;

        public AccessTypeModel GetAccessType() => AccessTypeModel.Public;
    }
}