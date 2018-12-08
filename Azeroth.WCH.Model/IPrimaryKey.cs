using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azeroth.WCH.Model
{
    public interface IPrimaryKey
    {
        Guid Id { set; get; }
    }
}
