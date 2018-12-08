using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azeroth.WCH.IBll
{
    public interface ICommon<T>:Model.IAutofacFlag
    {
        T GetById(Guid id);

        List<T> GetById(IEnumerable<Guid> id);
    }
}
