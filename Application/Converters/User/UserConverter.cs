using Infrastructure.Records.User;

namespace Application.Converters.User
{
    public class UserConverter : IConverter<UserRecord, Domain.Models.User.User>
    {
        public Domain.Models.User.User Convert(UserRecord source)
        {
            return new Domain.Models.User.User()
            {
                Id = source.Id,
                Login = source.Login,
                Password = source.Password
            };
        }

        public UserRecord Convert(Domain.Models.User.User source)
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