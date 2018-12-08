using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Azeroth.WCH.Model
{
    /// <summary>
    /// 文章表
    /// <summary>
    [Table("Document")]
    public partial class Document
    {
        /// <summary>
        ///主键
        /// </summary>
        [Required]
        [StringLength(36)]
        [Key]
        public String Id {set;get;}
        /// <summary>
        ///作者
        /// </summary>
        [Required]
        [StringLength(36)]
        public String Author {set;get;}
        /// <summary>
        ///正文
        /// </summary>
        [Required]
        public String Content {set;get;}
        /// <summary>
        ///标题
        /// </summary>
        [Required]
        [StringLength(128)]
        public String Title {set;get;}
        /// <summary>
        ///封面
        /// </summary>
        [StringLength(512)]
        public String CoverUrl {set;get;}
        /// <summary>
        ///摘要
        /// </summary>
        [Required]
        [StringLength(512)]
        public String ContentAbstract {set;get;}
        /// <summary>
        ///创建时间
        /// </summary>
        public DateTime CreateDateTime {set;get;}
    }
}
