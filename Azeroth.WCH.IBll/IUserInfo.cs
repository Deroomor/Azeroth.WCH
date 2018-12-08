using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azeroth.WCH.Model;

namespace Azeroth.WCH.IBll
{
    public interface IUserInfo:ICommon<Model.UserInfo>
    {
        /// <summary>
        /// 验证登陆
        /// 成功-返回该用户的相关信息
        /// 失败-返回null
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Model.UserInfo ValidateSignIn(Model.DTO.LoginInput parameter);
    }
}
