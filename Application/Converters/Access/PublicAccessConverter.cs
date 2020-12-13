using System;
using Domain.Models.Access;
using Infrastructure;

namespace Application.Converters.Access
{
    public class PublicAccessConverter : IAccessConverter
    {
        public IAccessParameters Get(Guid guid)
        {
            return new PublicAccessParameters();
        }
    }
}