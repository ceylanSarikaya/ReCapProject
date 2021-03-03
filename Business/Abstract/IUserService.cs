using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businees.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
