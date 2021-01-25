using System;
using Domain.Models.User;

namespace NotesFE.Views.ViewModels.Access
{
    public class OnlyOwnerAccessParametersModel : IAccessParametersModel
    {
        private readonly Guid owner;

        public OnlyOwnerAccessParametersModel(User owner)
        {
            this.owner = owner.Id;
        }

        public bool HasAccess(User user) => user.Id == owner;

        public AccessTypeModel GetAccessType() => AccessTypeModel.Owner;
    }
}