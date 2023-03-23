using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nightClub.Domain.Entities.User;

namespace nightClub.BusinessLogic.DBModel
{
    internal class UserContext: DbContext
    {
        public UserContext() :
            base("name=nightClub")
        {

        }
        public virtual DbSet<UDbTable> Users { get; set; }
    }
}
