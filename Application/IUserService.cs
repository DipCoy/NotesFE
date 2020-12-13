using Domain.Models;

namespace Application
{
    public interface IUserService
    {
        public bool TryGetUser(string login, out User user);
        public bool TryAddUser(User user);
    }
}