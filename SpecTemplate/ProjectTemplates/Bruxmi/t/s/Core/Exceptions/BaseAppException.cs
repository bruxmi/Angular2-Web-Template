using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    [Serializable]
    public class BaseAppException : Exception
    {
        public BaseAppException(string translationKey)
            : base(translationKey)
        {
        }

        public BaseAppException(string translationKey, Exception innerException) : base(translationKey, innerException)
        { }
    }
}
