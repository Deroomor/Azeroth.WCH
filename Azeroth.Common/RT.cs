using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Azeroth.Common
{
    /// <summary>
    /// 统一格式的json返回结果
    /// </summary>
    public class RT
    {
        public RT()
        {

        }
        public RT(string msg)
        {
            this.Msg = msg;
        }

        public System.Net.HttpStatusCode Status { get; set; }

        public string Msg { get; set; }

        public object Body { get; set; }
    }
}