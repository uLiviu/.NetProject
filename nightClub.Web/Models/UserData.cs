using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nightClub.Web.Models
{
    public class UserData
    {
        public string Username { get; set; }
        public List<string> ProducList { get; set; }
        public string SingleProduct { get; set; }
    }
}