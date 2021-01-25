using Application.Converters;
using Infrastructure.DataBases;
using Infrastructure.Records.User;

namespace Application.Services.User
{
    public class DefaultUserService : IUserService
    {
        private readonly IDataBaseOperations dataBase;
        private readonly IConverter<UserRecord, Domain.Models.User.User> userConverter;
        
        public DefaultUserService(IDataBaseOperations dataBase, IConverter<UserRecord, Domain.Models.User.User> userConverter)
        {
            this.dataBase = dataBase;
            this.userConverter = userConverter;
        }
        
        public bool TryGetUser(string login, out Domain.Models.User.User user)
        {
            if (dataBase.TryGetRecord<UserRecord>(x => x.Login == login, out var userRecord))
            {
                user = userConverter.Convert(userRecord);
                return true;
            }

            user = null;
            return false;
        }

        public bool TryAddUser(Domain.Models.User.User user)
        {
            return dataBase.TryAddRecord(userConverter.Convert(user), out var _);
        }
    }
}