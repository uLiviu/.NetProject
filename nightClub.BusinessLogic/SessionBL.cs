using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nightClub.BusinessLogic.Core;
using nightClub.BusinessLogic.Interfaces;
using nightClub.Domain.Entities.User;

namespace nightClub.BusinessLogic
{
    public class SessionBL: UserApi, ISession
    {
        public ULoginResponse UserLogin(ULoginData data)
        {
            throw new NotImplementedException();
        }

        public string GetCookies(ULoginData loginData)
        {
            return UserAssignCookies(loginData);
        }

        public bool ValidateCookies(string cookies)
        {
            return UserCookiesValidator(cookies);
        }

    }
}
