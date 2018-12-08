using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azeroth.WCH.Model;
using Azeroth.WCH.Model.DTO;

namespace Azeroth.WCH.Bll
{
    public class UserInfo : Common<Model.UserInfo>, IBll.IUserInfo
    {
        

        public Model.UserInfo ValidateSignIn(LoginInput parameter)
        {
            var lst= this.DbContext.UserInfo.Where(x => x.LoginName == parameter.Name).ToList();
            if (lst.Count <= 0)
                return null;
            if (lst.Count > 1)
                throw new ArgumentException("数据异常,存在相同的账号,请联系管理员");
            var userInfo = lst[0];
            if (userInfo.Pwd != parameter.Password)
                return null;
            return userInfo;
        }
    }
}
