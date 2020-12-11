using Infrastructure.Records;

namespace Infrastructure
{
    public interface IUserOperations
    {
        public bool TryGetUserRecord(string login, out UserRecord userRecord);
        public bool TryAddUserRecord(UserRecord userRecord);
    }
}