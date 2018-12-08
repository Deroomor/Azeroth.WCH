using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Azeroth.WCH.Model
{
    /// <summary>
    /// 杀杀杀
    /// <summary>
    [Table("TbIndex")]
    public partial class TbIndex:IPrimaryKey
    {
        /// <summary>
        ///逐渐
        /// </summary>
        [Key]
        public Guid Id {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Int32 Age {set;get;}
        /// <summary>
        ///
        /// </summary>
        public DateTime Birthday {set;get;}
        /// <summary>
        ///水水
        /// </summary>
        public DateTime CreateDateTime {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Single Money {set;get;}
        /// <summary>
        ///类别
        /// </summary>
        public CategoryIndex CategoryEnum {set;get;}
    }
}
