using Application.Converters;
using Domain.Models;
using Infrastructure;
using Infrastructure.Records;

namespace Application
{
    public class DefaultUserService : IUserService
    {
        private readonly IDataBaseOperations dataBase;
        private readonly IConverter<UserRecord, User> userConverter;
        
        public DefaultUserService(IDataBaseOperations dataBase, IConverter<UserRecord, User> userConverter)
        {
            this.dataBase = dataBase;
            this.userConverter = userConverter;
        }
        
        public bool TryGetUser(string login, out User user)
        {
            if (dataBase.TryGetRecord<UserRecord>(x => x.Login == login, out var userRecord))
            {
                user = userConverter.Convert(userRecord);
                return true;
            }

            user = null;
            return false;
        }

        public bool TryAddUser(User user)
        {
            return dataBase.TryAddRecord(userConverter.Convert(user));
        }
    }
}