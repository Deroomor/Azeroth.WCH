using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Azeroth.WCH.Model.DTO
{
    public class LoginInput
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage ="用户名不能为空")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "密码不能为空")]
        public string Password { get; set; }
    }
}