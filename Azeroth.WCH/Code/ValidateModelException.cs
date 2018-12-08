using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azeroth
{
    public class ValidateModelException:System.Exception
    {
        public  System.Web.Mvc.ModelStateDictionary DictError {private set; get; }

        public ValidateModelException(System.Web.Mvc.ModelStateDictionary md)
        {
            
            this.DictError = md;
        }
    }
}
