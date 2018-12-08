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
        protected void Page_Load(object sender, EventArgs e)
        {
            IBll.IUserInfo bllUserInfo = new Bll.UserInfo();
            Model.UserInfo userInfo = new Model.UserInfo() {
                CellPhoneNumber = "15616104092",
                 Id=Guid.NewGuid(),
                  ImgUrl=string.Empty,
                   LoginName="eeroom",
                    NickName="丢了光影",
                     Pwd="123"
            };
            bllUserInfo.Add(userInfo);
        }
    }
}