using System;
using Domain.Models.Access;
using Infrastructure;

namespace Application.Converters.Access
{
    public class PublicAccessService : IAccessService
    {
        public IAccessParameters FromLink(string link)
        {
            return new PublicAccessParameters();
        }
    }
}