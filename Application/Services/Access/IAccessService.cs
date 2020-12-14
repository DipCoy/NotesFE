using System;
using Domain.Models.Access;
using Infrastructure;

namespace Application.Converters.Access
{
    public interface IAccessService
    {
        IAccessParameters FromLink(string link);
    }
}