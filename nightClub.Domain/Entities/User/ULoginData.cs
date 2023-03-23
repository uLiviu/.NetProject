using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace nightClub.Domain.Entities.User
{
    public class ULoginData
    {
        public String Credential { get; set; }
        public String Password { get; set; }
        public String LoginIP { get; set; }
        public DateTime LoginDateTime { get; set; }
    }
}
