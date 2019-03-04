using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
namespace Azeroth.WCHAPI.Controllers
{

    public class HomeController:ApiController
    {
        public RT<WCH.Model.UserInfo>  Login() 
        {
            
            return new RT<WCH.Model.UserInfo>() {
                data = new WCH.Model.UserInfo() {
                    CellPhoneNumber = "15150232263",
                    Id = Guid.NewGuid(),
                    ImgUrl = "http://www.baidu.com",
                    LoginName = "eeroom",
                    NickName = "丢了光影",
                    Pwd = "123456"
                },
                code = RTCode.Ok,
                msg = "登陆成功"

            };
        }
    }
}