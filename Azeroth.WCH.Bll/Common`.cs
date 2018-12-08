using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azeroth.WCH.Bll
{
    public abstract class Common<T>: Model.IAutofacFlag  where T : class,Model.IPrimaryKey
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
    }
}
