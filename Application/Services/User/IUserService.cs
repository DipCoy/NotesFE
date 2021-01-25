namespace Application.Services.User
{
    public interface IUserService
    {
        public bool TryGetUser(string login, out Domain.Models.User.User user);
        public bool TryAddUser(Domain.Models.User.User user);
    }
}