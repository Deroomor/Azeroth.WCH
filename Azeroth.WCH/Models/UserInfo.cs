using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Azeroth.WCH.Models
{
    public class UserInfo
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }
    }
}