using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nightClub.Domain.Entities.User;

namespace nightClub.BusinessLogic.Core
{
    public class UserApi
    {
        public string UserAssignCookies(ULoginData loginData)
        {
            return "cookies";
        }

        public bool UserCookiesValidator(string cookies)
        {
            return true;
        }

        public string GetProduct(int id)
        {
            return "product";
        }
    }
}
