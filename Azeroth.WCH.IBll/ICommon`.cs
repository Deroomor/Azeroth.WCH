using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace Azeroth.WCH.IBll
{
    public interface ICommon<T>:Model.IAutofacFlag
    {
        T GetById(Guid id);

        List<T> GetById(IEnumerable<Guid> id);

        int Add(T entity);

        int Add(IEnumerable<T> entity);

        int EditById<S>(T entity, Expression<Func<T, S>> selector);
    }
}
