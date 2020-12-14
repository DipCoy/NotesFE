using Domain.Models.Access;
using Infrastructure.Records.Access;

namespace Application.Converters.Access
{
    public class PrivateAccessConverter : IConverter<PrivateAccessRecord, PrivateAccessParameters>
    {
        public PrivateAccessParameters Convert(PrivateAccessRecord source)
        {
            return new PrivateAccessParameters(source.AccessedUsers);
        }

        public PrivateAccessRecord Convert(PrivateAccessParameters source)
        {
            return new PrivateAccessRecord()
            {
                AccessedUsers = source.HavingAccess
            };
        }
    }
}