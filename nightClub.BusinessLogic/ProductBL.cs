using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nightClub.BusinessLogic.Core;
using nightClub.BusinessLogic.Interfaces;

namespace nightClub.BusinessLogic
{
    public class ProductBL:UserApi, IProduct
    {
        public string GetProductByID(int id)
        {
            return GetProduct(id);
        }
    }
}
