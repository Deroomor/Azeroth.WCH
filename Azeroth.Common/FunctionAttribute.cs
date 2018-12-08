using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Azeroth.Common
{
    public class FunctionCommentAttribute : System.Attribute
    {
        public string Name { get; set; }
        public string RouteUrl { get; set; }
        public FunctionCommentAttribute(string name)
        {
            this.Name = name;
        }
    }
}