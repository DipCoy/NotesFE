using Domain.Models.Access;

namespace Application.Services.Access
{
    public class PublicAccessService : IAccessService
    {
        public IAccessParameters FromLink(string link)
        {
            return new PublicAccessParameters();
        }
    }
}