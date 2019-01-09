
using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Azeroth.WCH.Model
{
    public partial class DbContext : System.Data.Entity.DbContext
    {
        public DbContext() : base("name=master")
        {
        }    
        /// <summary>
        /// 文章表
        /// <summary>
        public virtual DbSet<Document> Document { get; set; }
        /// <summary>
        /// 杀杀杀
        /// <summary>
        public virtual DbSet<TbIndex> TbIndex { get; set; }
        /// <summary>
        /// 用户表
        /// <summary>
        public virtual DbSet<UserInfo> UserInfo { get; set; }
    }
}
