using Domain.Models;
using Infrastructure.Records;

namespace Application.Converters
{
    public class UserConverter : IConverter<UserRecord, User>
    {
        public User Convert(UserRecord source)
        {
            return new User()
            {
                Id = source.Id,
                Login = source.Login,
                Password = source.Password
            };
        }

        public UserRecord Convert(User source)
        {
            return new UserRecord()
            {
                Id = source.Id,
                Login = source.Login,
                Password = source.Password
            };
        }
    }
}