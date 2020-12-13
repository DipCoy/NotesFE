using System;
using Domain.Models.Access;
using Infrastructure;

namespace Application.Converters.Access
{
    public interface IAccessConverter
    {
        IAccessParameters Get(Guid guid);
    }
}