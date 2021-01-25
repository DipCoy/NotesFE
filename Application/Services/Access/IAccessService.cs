using Domain.Models.Access;

namespace Application.Services.Access
{
    public interface IAccessService
    {
        IAccessParameters FromLink(string link);
    }
}