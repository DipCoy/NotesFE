using System;
using Domain.Models;
using Infrastructure;

namespace Application.Converters
{
    public class PublicAccessConverter : IAccessConverter
    {
        public IAccessParameters Get(Guid guid)
        {
            return new PublicAccessParameters();
        }
    }

    public class PrivateAccessConverter : IAccessConverter
    {
        private readonly IUserOperations userOperations;

        public PrivateAccessConverter(IUserOperations userOperations)
        {
            this.userOperations = userOperations;
        }


        public IAccessParameters Get(Guid guid)
        {
            var accessParams = userOperations.TryGetUserRecord(guid.ToString(), out var result);
            
            return new PrivateAccessParameters(result);
        }
    }
}