using System;
using Domain.Models;

namespace Application.Converters
{
    public interface IAccessConverter
    {
        IAccessParameters Get(Guid guid);
    }
}