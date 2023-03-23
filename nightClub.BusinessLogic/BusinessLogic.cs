using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nightClub.BusinessLogic.Interfaces;

namespace nightClub.BusinessLogic
{
    public class BusinessLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
        public IProduct GetProductBL()
        {
            return new ProductBL();
        }
    }
}
