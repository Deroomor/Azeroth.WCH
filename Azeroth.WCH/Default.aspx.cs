using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Azeroth.WCH
{
    public partial class Default : System.Web.UI.Page
    {
        public string RT { get; set; }
        protected override void OnLoad(EventArgs e)
        {
            var txt= this.Request["plainText"];
            var key= System.Configuration.ConfigurationManager.AppSettings["mssqlmaster:key"];
        }
    }
}