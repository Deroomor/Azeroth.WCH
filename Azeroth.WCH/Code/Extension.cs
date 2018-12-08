using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Web
{
    public static class WebExtension
    {
        public static void SetValue(this System.Web.HttpSessionStateBase session,SessionIndex sindex,object value)
        {
            session[sindex.ToString()] = value;
        }

        public static object GetValue(this System.Web.HttpSessionStateBase session, SessionIndex sindex)
        {
            return session[sindex.ToString()];
        }
    }

    public enum SessionIndex
    {
        UserInfo,
    }
}
