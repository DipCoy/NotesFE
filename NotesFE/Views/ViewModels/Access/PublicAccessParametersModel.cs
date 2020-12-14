using Domain.Models;

namespace Domain.ViewModels.AccessModel
{
    public class PublicAccessParametersModel : IAccessParametersModel
    {
        public bool HasAccess(User user) => true;

        public AccessTypeModel GetAccessType() => AccessTypeModel.Public;
    }
}