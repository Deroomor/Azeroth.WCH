using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Azeroth.WCHAPI
{
    public class RT
    {
        public int code { get; set; }
        public string msg { get; set; }
        public object data { get; set; }
        public object extension { get; set; }

        
    }

    public enum RTCode
    {
        Ok = 1,
        Error = 2,
        NoAuthentication = 3,
        NoAuthorization = 4
    }
}