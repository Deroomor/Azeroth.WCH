using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azeroth.WCH.Model
{
    /// <summary>
    /// 用户信息
    /// <summary>
    [Table("user_info")]
    public partial class User_Info
    {
        /// <summary>
        ///主键标识
        /// </summary>
        [Key]
        [Column("id")]
        public Guid Id { set; get; }
        /// <summary>
        ///用户名
        /// </summary>
        [Required]
        [StringLength(50)]
        [Column("name")]
        public String Name { set; get; }
        /// <summary>
        ///密码
        /// </summary>
        [Required]
        [StringLength(50)]
        [Column("password")]
        public String Password { set; get; }
        /// <summary>
        ///租户ID
        /// </summary>
        [Column("tenant_id")]
        public Guid Tenant_Id { set; get; }
    }
}
