using Domain.Models;

namespace Application
{
    public interface IUserService
    {
        public bool TryGetUser(string login, string password, out User user);
        public bool TryAddUser(User user);
    }
}