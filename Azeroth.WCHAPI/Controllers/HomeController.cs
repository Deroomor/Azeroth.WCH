using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
namespace Azeroth.WCHAPI.Controllers
{

    public class HomeController:ApiController
    {
        public WCH.Model.UserInfo Login() 
        {
            return new WCH.Model.UserInfo() {  CellPhoneNumber="15150232263", Id=Guid.NewGuid(), ImgUrl="http://www.baidu.com", LoginName="eeroom",
              NickName="丢了光影",
             Pwd="123456"};
        }
    }
}