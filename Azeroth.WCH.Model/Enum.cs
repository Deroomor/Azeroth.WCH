using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azeroth.WCH.Model
{

    public static class  EnumExtension
    {


        public static string ToTXT(this Enum value)
        {
            return value.ToString();
        }
    }

    public enum CategoryIndex
    {
        [System.ComponentModel.Description("人事")]
        HR,
        [System.ComponentModel.Description("财务")]
        Finance
    }
}
