using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nightClub.BusinessLogic.Core;
using nightClub.Domain.Entities.User;

namespace nightClub.BusinessLogic.Interfaces
{
    public interface ISession
    {
        ULoginResponse UserLogin(ULoginData data);
        string GetCookies(ULoginData loginData);
        bool ValidateCookies(string cookies);

    }
}
