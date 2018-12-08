using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Azeroth.WCH.Model
{
    /// <summary>
    /// 用户表
    /// <summary>
    [Table("UserInfo")]
    public partial class UserInfo
    {
        /// <summary>
        ///主键
        /// </summary>
        [Required]
        [StringLength(36)]
        [Key]
        public String Id {set;get;}
        /// <summary>
        ///登陆名称
        /// </summary>
        [Required]
        [StringLength(128)]
        public String LoginName {set;get;}
        /// <summary>
        ///昵称
        /// </summary>
        [Required]
        [StringLength(128)]
        public String NickName {set;get;}
        /// <summary>
        ///手机号码
        /// </summary>
        [Required]
        [StringLength(128)]
        public String CellPhoneNumber {set;get;}
        /// <summary>
        ///头像的图片路径
        /// </summary>
        [Required]
        [StringLength(512)]
        public String ImgUrl {set;get;}
        /// <summary>
        ///密码
        /// </summary>
        [Required]
        [StringLength(128)]
        public String Pwd {set;get;}
    }
}
