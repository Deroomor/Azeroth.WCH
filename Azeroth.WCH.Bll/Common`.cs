using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azeroth.WCH.Bll
{
    public abstract class Common<T>: IBll.ICommon<T>,Model.IAutofacFlag  where T : class,Model.IPrimaryKey
    {
        protected Model.DbContext DbContext { private set; get; }

        public Common()
        {
            this.DbContext= System.Runtime.Remoting.Messaging.CallContext.GetData(Azeroth.Common.Flags.DbContext) as Model.DbContext;
            if(this.DbContext==null)
            {
                this.DbContext = new Model.DbContext();
                System.Runtime.Remoting.Messaging.CallContext.SetData(Azeroth.Common.Flags.DbContext, this.DbContext);
            }
        }

        public T GetById(Guid id)
        {
            var rt= this.DbContext.Set<T>().Where(x => x.Id == id).FirstOrDefault();
            return rt;
        }

        public List<T> GetById(IEnumerable<Guid> id)
        {
            var rt = this.DbContext.Set<T>().Where(x => id.Contains(x.Id)).ToList();
            return rt;
        }

        /// <summary>
        /// 获取当前的用户信息
        /// 避免直接依赖httpcontext或者其它线程内全局数据
        /// </summary>
        /// <returns></returns>
        public Model.UserInfo GetUserInfo()
        {
            var rt= System.Runtime.Remoting.Messaging.CallContext.GetData(Azeroth.Common.Flags.UserInfo) as Model.UserInfo;
            return rt;
        }

        public int Add(T entity)
        {
             this.DbContext.Set<T>().Add(entity);
            return this.DbContext.SaveChanges();
        }

        public int Add(IEnumerable<T> entity)
        {
            this.DbContext.Set<T>().AddRange(entity);
            return this.DbContext.SaveChanges();
        }


        public int EditById<S>(T entity, System.Linq.Expressions.Expression<Func<T, S>> selector)
        {
            var wrapper= this.DbContext.Entry(entity);
            wrapper.State = System.Data.Entity.EntityState.Unchanged;
            List<string> lstName= GetPropertyName(selector.Body);
            lstName.ForEach(x => wrapper.Property(x).IsModified = true);
            var rt = this.DbContext.SaveChanges();
            return rt;
            
        }

        private List<string> GetPropertyName(System.Linq.Expressions.Expression expression)
        {
            var mexp= expression as System.Linq.Expressions.MemberExpression;
            if (mexp != null)
                return new List<string>() { mexp.Member.Name};
            var nexp = expression as System.Linq.Expressions.NewExpression;
            if (nexp != null)
                return nexp.Members.Select(x => x.Name).ToList();
            throw new ArgumentException("不识别的表达式："+expression.ToString());
        }


    }
}
